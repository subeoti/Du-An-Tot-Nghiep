using DaTa.Model;
using DaTa.ViewModel.NewFolder;
using Microsoft.EntityFrameworkCore;
using WebAPI.IServices;

namespace WebAPI.Services
{
    public class SanPhamServices : ISanPhamServices
    {
        private readonly CHGiayDBContext dBContext;
        public SanPhamServices()
        {
            this.dBContext = new CHGiayDBContext();
        }
        public async Task<bool> CheckTrungTT(SanPham tt)
        {
            if (!dBContext.SanPhams.AsNoTracking().Any(c => c.Ten == tt.Ten && c.ID != tt.ID))
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteSanPham(Guid id)
        {
            // Kiểm tra thuộc tính đã có sản phẩm nào sử dụng
            var tt = await dBContext.SanPhams.FindAsync(id);
            if (tt != null)
            {
                // Xóa toàn bộ giá trị 
                var listgtr = await dBContext.Anhs.AsNoTracking().Where(c => c.IDSanPham == tt.ID).ToListAsync();
                listgtr.RemoveRange(0, listgtr.Count);
                await dBContext.SaveChangesAsync();
                // Xóa thuộc tính
                dBContext.Remove(tt);
                await dBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<SanPham>> GetAllSanPham()
        {
            try
            {
                return await dBContext.SanPhams.OrderByDescending(x => x.TrangThai).ToListAsync();
            }
            catch (Exception)
            {

                throw;

            }
           
        }

        public async Task<SanPhamRequest> GetByID(Guid idtt)
        {
            var result = await(from tt in dBContext.SanPhams.AsNoTracking()
                               where tt.ID == idtt
                               select new SanPhamRequest()
                               {
                                   ID = tt.ID,
                                   Ten = tt.Ten,
                                   TrangThai = tt.TrangThai,
                                   Anh = (from gt in dBContext.Anhs.AsNoTracking()
                                                     where gt.IDSanPham == tt.ID
                                                     select new Anh()
                                                     {
                                                         ID = gt.ID,
                                                         AnhSP = gt.AnhSP,
                                                     }).ToList()

                               }).FirstOrDefaultAsync();
            return result;
        }

        public async Task<SanPham> SaveSanPham(string ten, string ma, string mota, int gia, DateTime ngaytao, int trangthai, Guid idnsx, Guid idthieu, Guid idloaisp, Guid idchatlieu, Guid idkhuyenm)
        {
            try
            {
                var existingColor = await dBContext.SanPhams.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                if (existingColor != null)
                {
                    return null;
                }
                SanPham sp = new SanPham()
                {
                    ID = Guid.NewGuid(),
                    Ten = ten,
                    Ma = ma,
                    GiaBan = gia,
                    NgayTao= ngaytao,
                    MoTa=mota,
                    TrangThai=trangthai,
                    IDChatLieu = idchatlieu,
                    IDKhuyenMai=idkhuyenm,
                    IDLoaiSP=idloaisp,
                    IDNSX=idnsx,
                    IDThuongHieu=idthieu,
                };
                dBContext.SanPhams.Add(sp);
                dBContext.SaveChanges();
                return sp;

            }
            catch (Exception)
            {

                throw;

            }
        }

       
    }
}
