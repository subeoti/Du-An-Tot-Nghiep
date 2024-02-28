using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class SanPham
    {
        public Guid ID { get; set; }
        [StringLength(200, ErrorMessage = "Ten san pham khong duoc dai qua 40 tu.")]
        public string Ten { get; set; }
        public string? Ma { get; set; }
        public string? MoTa { get; set; }
        public int GiaBan { get; set; }
        public DateTime NgayTao { get; set; }
        public int TrangThai { get; set; }
        public Guid IDNSX { get; set; }
        public Guid IDThuongHieu { get; set; }
        public Guid IDLoaiSP { get; set; }
        public Guid IDChatLieu { get; set; }
        public Guid IDKhuyenMai { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }
        public virtual ChatLieu ChatLieu { get; set; }
        public virtual NSX NSX { get; set; }
        public virtual ThuongHieu ThuongHieu { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public virtual IEnumerable<SanPhamCT> SanPhamCTs { get; set; }
        public virtual IEnumerable<Anh> Anhs { get; set; }
    }
}
