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
        public async Task<bool> CheckTrungTT(SanPhamRequest tt)
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
            //var listtt = await(from tt in dBContext.SanPhams.AsNoTracking()
            //                   select new SanPhamRequest()
            //                   {
            //                       ID = tt.ID,
            //                       TrangThai = tt.TrangThai,
            //                       Ten = tt.Ten,
            //                       Anh = (from gt in dBContext.Anhs
            //                                         where tt.ID == gt.ID
            //                                         select new Anh()
            //                                         {
            //                                             ID = gt.ID,
            //                                             AnhSP = gt.AnhSP,
            //                                         }).ToList()
            //                   }).ToListAsync();
            //return listtt;
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

        public async Task<SanPham> SaveSanPham(SanPhamRequest tt)
        {
            var exist = await dBContext.SanPhams.FindAsync(tt.ID);
            if (exist != null)//Tồn tại
            {
                exist.Ten = tt.Ten;
                exist.TrangThai = tt.TrangThai;
                dBContext.SanPhams.Update(exist);
                await dBContext.SaveChangesAsync();
                // Giá trị
                foreach (var gt in tt.Anh)
                {
                    // Check TT đã có GT này
                    var gtr = await dBContext.Anhs.AsNoTracking().Where(c => c.ID == exist.ID && c.ID == gt.ID).FirstOrDefaultAsync();

                    if (gtr == null) // Chưa có -> Tạo GT
                    {
                        Anh giaTri = new Anh()
                        {
                            ID = new Guid(),
                            IDSanPham = exist.ID,
                            AnhSP = gt.AnhSP,
                        };
                        await dBContext.Anhs.AddAsync(giaTri);
                        await dBContext.SaveChangesAsync();
                    }
                }
                return exist;
            }
            else // Chưa có -> Tạo Thuộc tính ms
            {
                SanPham thuocTinh = new SanPham()
                {
                    Ten = tt.Ten,
                    Ma = tt.Ma,
                    MoTa = tt.MoTa,
                    TrangThai = tt.TrangThai,
                    IDNSX = tt.IDNSX,
                    IDChatLieu = tt.IDChatLieu,
                    IDKhuyenMai= tt.IDKhuyenMai,
                    IDThuongHieu= tt.IDThuongHieu,
                    IDLoaiSP = tt.IDLoaiSP,
                };
                await dBContext.SanPhams.AddAsync(thuocTinh);
                await dBContext.SaveChangesAsync();
                // Tạo GT
                foreach (var gt in tt.Anh)
                {
                    Anh giaTri = new Anh()
                    {
                        ID = new Guid(),
                        IDSanPham = thuocTinh.ID,
                        AnhSP = gt.AnhSP,
                    };
                    await dBContext.Anhs.AddAsync(giaTri);
                    await dBContext.SaveChangesAsync();
                }
                return thuocTinh;
            }
        }
    }
}
