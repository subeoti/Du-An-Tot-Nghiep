using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class SanPhamCT
    {
        public Guid ID { get; set; }
        public int Ma { get; set; }
        public int SoLuong { get; set; }
        public int TrangThai { get; set; }
        public Guid IDKichCo { get; set; }
        public Guid IDSanPham { get; set; }
        public virtual KichCo KichCo { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual IEnumerable<HoaDonCT> HoaDonCTs { get; set; }
        public virtual IEnumerable<GioHangCT> GioHangCTs { get; set; }

    }
}
