using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaTa.Migrations
{
    public partial class _85628022024 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_SanPham_SanPhamID",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_SanPhamID",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "GiaBan",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "SanPhamID",
                table: "ChiTietSanPham");

            migrationBuilder.AddColumn<int>(
                name: "GiaBan",
                table: "SanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "SanPham",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "IDSanPham",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IDSanPham",
                table: "ChiTietSanPham",
                column: "IDSanPham");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_SanPham_IDSanPham",
                table: "ChiTietSanPham",
                column: "IDSanPham",
                principalTable: "SanPham",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_SanPham_IDSanPham",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_IDSanPham",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "GiaBan",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "IDSanPham",
                table: "ChiTietSanPham");

            migrationBuilder.AddColumn<int>(
                name: "GiaBan",
                table: "ChiTietSanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "ChiTietSanPham",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "SanPhamID",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_SanPhamID",
                table: "ChiTietSanPham",
                column: "SanPhamID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_SanPham_SanPhamID",
                table: "ChiTietSanPham",
                column: "SanPhamID",
                principalTable: "SanPham",
                principalColumn: "ID");
        }
    }
}
