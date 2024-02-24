﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class NhanVien
    {
        public Guid ID { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string? SDT { get; set; }
        public string? DiaChi { get; set; }
        public int? TrangThai { get; set; }
        public Guid IDVaiTro { get; set; }
        public virtual IEnumerable<HoaDon>? HoaDons { get; set; }
        public virtual VaiTro? VaiTro { get; set; }
    }
}
