using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceRemake.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(nullable: false),
                    DonGia = table.Column<decimal>(nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: false),
                    CauHinh = table.Column<string>(nullable: true),
                    MoTa = table.Column<string>(nullable: true),
                    HinhAnh = table.Column<string>(nullable: true),
                    SoLuongTon = table.Column<int>(nullable: false),
                    LuotXem = table.Column<int>(nullable: false),
                    LuotBinhLuan = table.Column<int>(nullable: false),
                    SoLanMua = table.Column<int>(nullable: false),
                    Moi = table.Column<int>(nullable: false),
                    MaLoai = table.Column<int>(nullable: false),
                    DaXoa = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.MaSP);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPham");
        }
    }
}
