﻿// <auto-generated />
using System;
using DaTa.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DaTa.Migrations
{
    [DbContext(typeof(CHGiayDBContext))]
    [Migration("20240222045446_1234")]
    partial class _1234
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DaTa.Model.Anh", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AnhSP")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("IDSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDSanPham");

                    b.ToTable("Anh", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.ChatLieu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ChatLieu", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.GioHang", b =>
                {
                    b.Property<Guid>("IDKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime");

                    b.HasKey("IDKhachHang");

                    b.ToTable("GioHang", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.GioHangCT", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDNguoiDung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSanPhamCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDNguoiDung");

                    b.HasIndex("IDSanPhamCT");

                    b.ToTable("ChiTietGioHang", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.HoaDon", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("IDKhacHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDVoucher")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LoaiHD")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayThanhToan")
                        .HasColumnType("datetime");

                    b.Property<string>("PhuongThucThanhToan")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TenNguoiNhan")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ThueVAT")
                        .HasColumnType("int");

                    b.Property<int>("TienShip")
                        .HasColumnType("int");

                    b.Property<int?>("TongTien")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDKhacHang");

                    b.HasIndex("IDNhanVien");

                    b.HasIndex("IDVoucher");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.HoaDonCT", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<Guid>("IDHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSanPHamCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDHoaDon");

                    b.HasIndex("IDSanPHamCT");

                    b.ToTable("ChiTietHoaDon", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.KhachHang", b =>
                {
                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DiemTich")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.KhuyenMai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GiaTri")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("NgayApDung")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("KhuyenMai", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.KichCo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KichCo", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.LoaiSanPham", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("LoaiSP", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.NhanVien", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("IDVaiTro")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDVaiTro");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.NSX", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("NSX", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.PhuongThucTT", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PhuongThucThanhToan", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.PhuongThucTTCT", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDPTTT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoTien")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDHoaDon");

                    b.HasIndex("IDPTTT");

                    b.ToTable("ChiTietPTTT", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.SanPham", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDChatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDKhuyenMai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDLoaiSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDNSX")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDThuongHieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KhuyenMaiId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDChatLieu");

                    b.HasIndex("IDLoaiSP");

                    b.HasIndex("IDNSX");

                    b.HasIndex("IDThuongHieu");

                    b.HasIndex("KhuyenMaiId");

                    b.ToTable("SanPham", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.SanPhamCT", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GiaBan")
                        .HasColumnType("int");

                    b.Property<Guid>("IDKichCo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Ma")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("SanPhamID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDKichCo");

                    b.HasIndex("SanPhamID");

                    b.ToTable("ChiTietSanPham", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.ThuongHieu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ThuongHieu", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.VaiTro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VaiTro", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.Voucher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GiaTri")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("NgayApDung")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("SoTienCan")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Voucher", (string)null);
                });

            modelBuilder.Entity("DaTa.Model.Anh", b =>
                {
                    b.HasOne("DaTa.Model.SanPham", "SanPham")
                        .WithMany("Anhs")
                        .HasForeignKey("IDSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("DaTa.Model.GioHangCT", b =>
                {
                    b.HasOne("DaTa.Model.GioHang", "GioHang")
                        .WithMany("GioHangCTs")
                        .HasForeignKey("IDNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DaTa.Model.SanPhamCT", "SanPhamCT")
                        .WithMany("GioHangCTs")
                        .HasForeignKey("IDSanPhamCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GioHang");

                    b.Navigation("SanPhamCT");
                });

            modelBuilder.Entity("DaTa.Model.HoaDon", b =>
                {
                    b.HasOne("DaTa.Model.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDKhacHang");

                    b.HasOne("DaTa.Model.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDNhanVien");

                    b.HasOne("DaTa.Model.Voucher", "Voucher")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDVoucher");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("DaTa.Model.HoaDonCT", b =>
                {
                    b.HasOne("DaTa.Model.HoaDon", "HoaDon")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("IDHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DaTa.Model.SanPhamCT", "SanPhamCT")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("IDSanPHamCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SanPhamCT");
                });

            modelBuilder.Entity("DaTa.Model.KhachHang", b =>
                {
                    b.HasOne("DaTa.Model.GioHang", "GioHang")
                        .WithOne("KhachHang")
                        .HasForeignKey("DaTa.Model.KhachHang", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GioHang");
                });

            modelBuilder.Entity("DaTa.Model.NhanVien", b =>
                {
                    b.HasOne("DaTa.Model.VaiTro", "VaiTro")
                        .WithMany("NhanViens")
                        .HasForeignKey("IDVaiTro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VaiTro");
                });

            modelBuilder.Entity("DaTa.Model.PhuongThucTTCT", b =>
                {
                    b.HasOne("DaTa.Model.HoaDon", "HoaDon")
                        .WithMany("PhuongThucTTCTs")
                        .HasForeignKey("IDHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DaTa.Model.PhuongThucTT", "PhuongThucTT")
                        .WithMany("PhuongThucTTCTs")
                        .HasForeignKey("IDPTTT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("PhuongThucTT");
                });

            modelBuilder.Entity("DaTa.Model.SanPham", b =>
                {
                    b.HasOne("DaTa.Model.ChatLieu", "ChatLieu")
                        .WithMany("SanPhams")
                        .HasForeignKey("IDChatLieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DaTa.Model.LoaiSanPham", "LoaiSanPham")
                        .WithMany("SanPhams")
                        .HasForeignKey("IDLoaiSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DaTa.Model.NSX", "NSX")
                        .WithMany("SanPhams")
                        .HasForeignKey("IDNSX")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DaTa.Model.ThuongHieu", "ThuongHieu")
                        .WithMany("SanPhams")
                        .HasForeignKey("IDThuongHieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DaTa.Model.KhuyenMai", "KhuyenMai")
                        .WithMany("SanPhams")
                        .HasForeignKey("KhuyenMaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatLieu");

                    b.Navigation("KhuyenMai");

                    b.Navigation("LoaiSanPham");

                    b.Navigation("NSX");

                    b.Navigation("ThuongHieu");
                });

            modelBuilder.Entity("DaTa.Model.SanPhamCT", b =>
                {
                    b.HasOne("DaTa.Model.KichCo", "KichCo")
                        .WithMany("SanPhamCTs")
                        .HasForeignKey("IDKichCo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DaTa.Model.SanPham", null)
                        .WithMany("SanPhamCTs")
                        .HasForeignKey("SanPhamID");

                    b.Navigation("KichCo");
                });

            modelBuilder.Entity("DaTa.Model.ChatLieu", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("DaTa.Model.GioHang", b =>
                {
                    b.Navigation("GioHangCTs");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("DaTa.Model.HoaDon", b =>
                {
                    b.Navigation("HoaDonCTs");

                    b.Navigation("PhuongThucTTCTs");
                });

            modelBuilder.Entity("DaTa.Model.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("DaTa.Model.KhuyenMai", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("DaTa.Model.KichCo", b =>
                {
                    b.Navigation("SanPhamCTs");
                });

            modelBuilder.Entity("DaTa.Model.LoaiSanPham", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("DaTa.Model.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("DaTa.Model.NSX", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("DaTa.Model.PhuongThucTT", b =>
                {
                    b.Navigation("PhuongThucTTCTs");
                });

            modelBuilder.Entity("DaTa.Model.SanPham", b =>
                {
                    b.Navigation("Anhs");

                    b.Navigation("SanPhamCTs");
                });

            modelBuilder.Entity("DaTa.Model.SanPhamCT", b =>
                {
                    b.Navigation("GioHangCTs");

                    b.Navigation("HoaDonCTs");
                });

            modelBuilder.Entity("DaTa.Model.ThuongHieu", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("DaTa.Model.VaiTro", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("DaTa.Model.Voucher", b =>
                {
                    b.Navigation("HoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
