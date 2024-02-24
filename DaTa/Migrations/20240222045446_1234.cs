using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaTa.Migrations
{
    public partial class _1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anh_ChiTietSanPham_IDSanPhamCT",
                table: "Anh");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_ChatLieu_IDChatLieu",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_KhuyenMai_IDKhuyenMai",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_LoaiSP_IDLoaiSP",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_NSX_IDNSX",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_ThuongHieu_IDThuongHieu",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_IDChatLieu",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_IDKhuyenMai",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_IDLoaiSP",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_IDNSX",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_IDThuongHieu",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "IDChatLieu",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "IDKhuyenMai",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "IDLoaiSP",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "IDNSX",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "IDThuongHieu",
                table: "ChiTietSanPham");

            migrationBuilder.RenameColumn(
                name: "IDSanPhamCT",
                table: "Anh",
                newName: "IDSanPham");

            migrationBuilder.RenameIndex(
                name: "IX_Anh_IDSanPhamCT",
                table: "Anh",
                newName: "IX_Anh_IDSanPham");

            migrationBuilder.AddColumn<Guid>(
                name: "SanPhamID",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IDNSX = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDThuongHieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDLoaiSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhuyenMaiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SanPham_ChatLieu_IDChatLieu",
                        column: x => x.IDChatLieu,
                        principalTable: "ChatLieu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_KhuyenMai_KhuyenMaiId",
                        column: x => x.KhuyenMaiId,
                        principalTable: "KhuyenMai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSP_IDLoaiSP",
                        column: x => x.IDLoaiSP,
                        principalTable: "LoaiSP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_NSX_IDNSX",
                        column: x => x.IDNSX,
                        principalTable: "NSX",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_ThuongHieu_IDThuongHieu",
                        column: x => x.IDThuongHieu,
                        principalTable: "ThuongHieu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_SanPhamID",
                table: "ChiTietSanPham",
                column: "SanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IDChatLieu",
                table: "SanPham",
                column: "IDChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IDLoaiSP",
                table: "SanPham",
                column: "IDLoaiSP");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IDNSX",
                table: "SanPham",
                column: "IDNSX");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IDThuongHieu",
                table: "SanPham",
                column: "IDThuongHieu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_KhuyenMaiId",
                table: "SanPham",
                column: "KhuyenMaiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anh_SanPham_IDSanPham",
                table: "Anh",
                column: "IDSanPham",
                principalTable: "SanPham",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_SanPham_SanPhamID",
                table: "ChiTietSanPham",
                column: "SanPhamID",
                principalTable: "SanPham",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anh_SanPham_IDSanPham",
                table: "Anh");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_SanPham_SanPhamID",
                table: "ChiTietSanPham");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_SanPhamID",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "SanPhamID",
                table: "ChiTietSanPham");

            migrationBuilder.RenameColumn(
                name: "IDSanPham",
                table: "Anh",
                newName: "IDSanPhamCT");

            migrationBuilder.RenameIndex(
                name: "IX_Anh_IDSanPham",
                table: "Anh",
                newName: "IX_Anh_IDSanPhamCT");

            migrationBuilder.AddColumn<Guid>(
                name: "IDChatLieu",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IDKhuyenMai",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IDLoaiSP",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IDNSX",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IDThuongHieu",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IDChatLieu",
                table: "ChiTietSanPham",
                column: "IDChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IDKhuyenMai",
                table: "ChiTietSanPham",
                column: "IDKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IDLoaiSP",
                table: "ChiTietSanPham",
                column: "IDLoaiSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IDNSX",
                table: "ChiTietSanPham",
                column: "IDNSX");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IDThuongHieu",
                table: "ChiTietSanPham",
                column: "IDThuongHieu");

            migrationBuilder.AddForeignKey(
                name: "FK_Anh_ChiTietSanPham_IDSanPhamCT",
                table: "Anh",
                column: "IDSanPhamCT",
                principalTable: "ChiTietSanPham",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_ChatLieu_IDChatLieu",
                table: "ChiTietSanPham",
                column: "IDChatLieu",
                principalTable: "ChatLieu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_KhuyenMai_IDKhuyenMai",
                table: "ChiTietSanPham",
                column: "IDKhuyenMai",
                principalTable: "KhuyenMai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_LoaiSP_IDLoaiSP",
                table: "ChiTietSanPham",
                column: "IDLoaiSP",
                principalTable: "LoaiSP",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_NSX_IDNSX",
                table: "ChiTietSanPham",
                column: "IDNSX",
                principalTable: "NSX",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_ThuongHieu_IDThuongHieu",
                table: "ChiTietSanPham",
                column: "IDThuongHieu",
                principalTable: "ThuongHieu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
