using DaTa.Model;

namespace WebAPI.IServices
{
    public interface SanPhamCTIServices
    {
        Task<List<SanPhamCT>> GetAllSanPhamct();
        Task<SanPhamCT> GetSPCTByID(Guid idtt);
        Task<SanPhamCT> SaveSanPhamCT(int ma, int soluong, int trangthai, Guid idkc,Guid idsp);
        Task<SanPhamCT> UpdateSanPhamCT(Guid id, int ma, int soluong, int trangthai, Guid idkc, Guid idsp);
        Task<bool> DeleteSanPhamCT(Guid id);
        Task<bool> CheckTrungSPCT(SanPhamCT tt);
    }
}
