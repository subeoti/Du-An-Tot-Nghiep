using DaTa.Model;
using DaTa.ViewModel.NewFolder;

namespace WebAPI.IServices
{
    public interface ISanPhamServices
    {
        Task<List<SanPham>> GetAllSanPham();
        Task<SanPhamRequest> GetByID(Guid idtt);
        Task<SanPham> SaveSanPham(string ten, string ma, string mota, int gia, DateTime ngaytao, int trangthai,Guid idnsx, Guid idthieu, Guid idloaisp, Guid idchatlieu, Guid idkhuyenm);
        Task<bool> DeleteSanPham(Guid id);
        Task<bool> CheckTrungTT(SanPham tt);
    }
}
