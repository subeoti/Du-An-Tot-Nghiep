using DaTa.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Configurations
{
    internal class SanPhamConfi : IEntityTypeConfiguration<SanPham>
    
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
    {
        builder.ToTable("SanPham");
        builder.HasKey(x => x.ID);
        builder.Property(x => x.Ten).HasColumnType("nvarchar(500)");
        builder.Property(x => x.MoTa).HasColumnType("nvarchar(50)");
        builder.Property(x => x.TrangThai).HasColumnType("int");
        builder.HasOne(x => x.LoaiSanPham).WithMany(x => x.SanPhams).HasForeignKey(x => x.IDLoaiSP);
        builder.HasOne(x => x.ChatLieu).WithMany(x => x.SanPhams).HasForeignKey(x => x.IDChatLieu);
        builder.HasOne(x => x.NSX).WithMany(x => x.SanPhams).HasForeignKey(x => x.IDNSX);
        builder.HasOne(x => x.ThuongHieu).WithMany(x => x.SanPhams).HasForeignKey(x => x.IDThuongHieu);
            builder.HasOne(x => x.KhuyenMai).WithMany(x => x.SanPhams).HasForeignKey(x => x.IDKhuyenMai);
        }
}
}
