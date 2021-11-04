using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceRemake.Data.Migrations
{
    public partial class Initial_RelativeforSanPhamTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "loaiSPMaLoai",
                table: "SanPham",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BinhLuan",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentDetails = table.Column<string>(nullable: true),
                    Id = table.Column<string>(nullable: true),
                    MaSP = table.Column<int>(nullable: false),
                    SanPhamMaSP = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BinhLuan", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_BinhLuan_SanPham_SanPhamMaSP",
                        column: x => x.SanPhamMaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonDatHang",
                columns: table => new
                {
                    MaChiTietDDH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDDH = table.Column<int>(nullable: false),
                    MaSP = table.Column<int>(nullable: false),
                    TenSP = table.Column<string>(nullable: true),
                    SoLuongDat = table.Column<int>(nullable: false),
                    DonGia = table.Column<decimal>(nullable: false),
                    SanPhamMaSP = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonDatHang", x => x.MaChiTietDDH);
                    table.ForeignKey(
                        name: "FK_ChiTietDonDatHang_SanPham_SanPhamMaSP",
                        column: x => x.SanPhamMaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuNhap",
                columns: table => new
                {
                    MaChiTietPN = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPN = table.Column<int>(nullable: false),
                    MaSP = table.Column<int>(nullable: false),
                    DonGiaNhap = table.Column<decimal>(nullable: false),
                    SoLuongNhap = table.Column<int>(nullable: false),
                    SanPhamMaSP = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuNhap", x => x.MaChiTietPN);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhap_SanPham_SanPhamMaSP",
                        column: x => x.SanPhamMaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSP",
                columns: table => new
                {
                    MaLoai = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSP", x => x.MaLoai);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_loaiSPMaLoai",
                table: "SanPham",
                column: "loaiSPMaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuan_SanPhamMaSP",
                table: "BinhLuan",
                column: "SanPhamMaSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonDatHang_SanPhamMaSP",
                table: "ChiTietDonDatHang",
                column: "SanPhamMaSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhap_SanPhamMaSP",
                table: "ChiTietPhieuNhap",
                column: "SanPhamMaSP");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSP_loaiSPMaLoai",
                table: "SanPham",
                column: "loaiSPMaLoai",
                principalTable: "LoaiSP",
                principalColumn: "MaLoai",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSP_loaiSPMaLoai",
                table: "SanPham");

            migrationBuilder.DropTable(
                name: "BinhLuan");

            migrationBuilder.DropTable(
                name: "ChiTietDonDatHang");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuNhap");

            migrationBuilder.DropTable(
                name: "LoaiSP");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_loaiSPMaLoai",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "loaiSPMaLoai",
                table: "SanPham");
        }
    }
}
