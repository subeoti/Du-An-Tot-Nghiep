using DaTa.Model;
using DaTa.ViewModel.NewFolder;

namespace WebAPI.IServices
{
    public interface ThuocTinhIServices
    {
       
        #region ChatLieu
        Task<ChatLieu> AddChatLieu(string ten, int trangthai);
        Task<ChatLieu> GetChatLieuById(Guid id);
        Task<bool> DeleteChatLieu(Guid id);
        Task<ChatLieu> UpdateChatLieu(Guid id, string ten, int trangthai);
        Task<List<ChatLieu>> GetAllChatLieu();
        #endregion
        #region ThuongHieu
        Task<ThuongHieu> AddThuongHieu(string ten, int trangthai);
        Task<ThuongHieu> GetIdThuongHieu(Guid id);
        Task<bool> DeleteTH(Guid id);
        Task<ThuongHieu> UpdateThuongHieu(Guid id, string ten, int trangthai);
        Task<List<ThuongHieu>> GetAllThuongHieu();
        #endregion
        #region NSX
        Task<NSX> AddNSX(string ten, int trangthai);
        Task<NSX> GetIdNSX(Guid id);
        Task<bool> DeleteNSX(Guid id);
        Task<NSX> UpdateNSX(Guid id, string ten, int trangthai);
        Task<List<NSX>> GetAllNSX();
        #endregion

        #region LoaiSP
        Task<LoaiSanPham> AddLoaiSP(string ten, int trangthai);
        Task<LoaiSanPham> GetLoaiSPById(Guid id);
        Task<bool> DeleteLoaiSP(Guid id);
        Task<LoaiSanPham> UpdateLoaiSp(Guid id, string ten, int trangthai);
        Task<List<LoaiSanPham>> GetAllLoaiSP();
        #endregion
        #region KhuyemMai
        Task<KhuyenMai> AddKhuyemMai(string ten, int trangthai, int giatri, string mota,DateTime ngaybd,DateTime ngaykt);
        Task<KhuyenMai> GetLoaiKMById(Guid id);
        Task<bool> DeleteKhuyMai(Guid id);
        Task<KhuyenMai> UpdateKhuyenMai(Guid id, string ten, int trangthai, int giatri, string mota, DateTime ngaybd, DateTime ngaykt);
        Task<List<KhuyenMai>> GetAllKhuyenMai();
        #endregion
        #region Anh
        Task<Anh> AddAnh(string ten, Guid idsp);
        Task<Anh> GetAnhById(Guid id);
        Task<bool> DeleteAnh(Guid id);
        Task<Anh> UpdateAnh(Guid id, string ten, int trangthai, int giatri, string mota, DateTime ngaybd, DateTime ngaykt);
        Task<List<Anh>> GetAllAnh();
        #endregion
    }
}
