using DaTa.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.ViewModel.NewFolder
{
    public class SanPhamRequest
    {
        public Guid ID { get; set; }
        [StringLength(200, ErrorMessage = "Ten san pham khong duoc dai qua 40 tu.")]
        public string Ten { get; set; }
        public string? Ma { get; set; }
        public string? MoTa { get; set; }
        public int TrangThai { get; set; }
        public Guid IDNSX { get; set; }
        public Guid IDThuongHieu { get; set; }
        public Guid IDLoaiSP { get; set; }
        public Guid IDChatLieu { get; set; }
        public Guid IDKhuyenMai { get; set; }
        public List<Anh> Anh { get; set; }
    }
}
