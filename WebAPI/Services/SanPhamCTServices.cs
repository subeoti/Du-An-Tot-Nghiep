using DaTa.Model;
using Microsoft.EntityFrameworkCore;
using WebAPI.IServices;

namespace WebAPI.Services
{
    public class SanPhamCTServices : SanPhamCTIServices
    {
        private readonly CHGiayDBContext dBContext;
        public SanPhamCTServices()
        {
            this.dBContext = new CHGiayDBContext();
        }
        public Task<bool> CheckTrungSPCT(SanPhamCT tt)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteSanPhamCT(Guid id)
        {
            try
            {
                var spct = await dBContext.SanPhamCTs.FirstOrDefaultAsync(cl => cl.ID == id);
                if (spct != null)
                {
                    dBContext.SanPhamCTs.Remove(spct);
                    dBContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<SanPhamCT>> GetAllSanPhamct()
        {
            try
            {
                return await dBContext.SanPhamCTs.OrderByDescending(x => x.TrangThai).ToListAsync();
            }
            catch (Exception)
            {

                throw;

            }
        }

        public async Task<SanPhamCT> GetSPCTByID(Guid idtt)
        {
            try
            {
                var km = await dBContext.SanPhamCTs.FirstOrDefaultAsync(nv => nv.ID == idtt);
                return km;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public async Task<SanPhamCT> SaveSanPhamCT(int ma, int soluong, int trangthai, Guid idkc, Guid idsp)
        {
            try
            {
                var existingColor = await dBContext.SanPhamCTs.FirstOrDefaultAsync(x => x.IDKichCo == idkc);
                if (existingColor != null)
                {
                    return null;
                }
                SanPhamCT spct = new SanPhamCT()
                {
                    ID = Guid.NewGuid(),
                    Ma = ma,
                    SoLuong = soluong,
                    TrangThai = trangthai,
                    IDKichCo = idkc,
                    IDSanPham= idsp
                };
                dBContext.SanPhamCTs.Add(spct);
                dBContext.SaveChanges();
                return spct;

            }
            catch (Exception)
            {

                throw;

            }
        }

        public async Task<SanPhamCT> UpdateSanPhamCT(Guid id, int ma, int soluong, int trangthai, Guid idkc, Guid idsp)
        {
            try
            {
                var kc = await dBContext.SanPhamCTs.FirstOrDefaultAsync(x => x.ID == id);
                if (kc != null)
                {
                    kc.Ma = ma;
                    kc.SoLuong = soluong;   
                    kc.TrangThai = 1;
                    kc.IDKichCo = idkc;
                    kc.IDSanPham= idsp;
                    dBContext.SanPhamCTs.Update(kc);
                    dBContext.SaveChanges();
                    return kc;
                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
