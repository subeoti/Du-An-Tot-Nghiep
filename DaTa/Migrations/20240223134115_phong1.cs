using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaTa.Migrations
{
    public partial class phong1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_KhuyenMai_KhuyenMaiId",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_KhuyenMaiId",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "KhuyenMaiId",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "Anh");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IDKhuyenMai",
                table: "SanPham",
                column: "IDKhuyenMai");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_KhuyenMai_IDKhuyenMai",
                table: "SanPham",
                column: "IDKhuyenMai",
                principalTable: "KhuyenMai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_KhuyenMai_IDKhuyenMai",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_IDKhuyenMai",
                table: "SanPham");

            migrationBuilder.AddColumn<Guid>(
                name: "KhuyenMaiId",
                table: "SanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "Anh",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_KhuyenMaiId",
                table: "SanPham",
                column: "KhuyenMaiId");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_KhuyenMai_KhuyenMaiId",
                table: "SanPham",
                column: "KhuyenMaiId",
                principalTable: "KhuyenMai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
