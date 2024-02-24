﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class KhuyenMai
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public int GiaTri { get; set; }
        public DateTime NgayApDung { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string MoTa { get; set; }
        public int Status { get; set; }
        public virtual IEnumerable<SanPham> SanPhams { get; set; }
    }
}
