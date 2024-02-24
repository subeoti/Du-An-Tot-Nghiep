using DaTa.Model;
using DaTa.ViewModel.NewFolder;

namespace WebAPI.IServices
{
    public interface ISanPhamServices
    {
        Task<List<SanPham>> GetAllSanPham();
        Task<SanPhamRequest> GetByID(Guid idtt);
        Task<SanPham> SaveSanPham(SanPhamRequest tt);
        Task<bool> DeleteSanPham(Guid id);
        Task<bool> CheckTrungTT(SanPhamRequest tt);
    }
}
