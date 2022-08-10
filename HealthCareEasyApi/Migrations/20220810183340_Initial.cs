using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthCareEasyApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dichvu",
                columns: table => new
                {
                    DichvuId = table.Column<int>(type: "int", nullable: false),
                    Tendichvu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dichvu", x => x.DichvuId);
                });

            migrationBuilder.CreateTable(
                name: "Benhvien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Benhvien_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tenbenhvien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thongtin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Giatien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DichvuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benhvien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Benhvien_Dichvu_DichvuId",
                        column: x => x.DichvuId,
                        principalTable: "Dichvu",
                        principalColumn: "DichvuId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Benhvien_DichvuId",
                table: "Benhvien",
                column: "DichvuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Benhvien");

            migrationBuilder.DropTable(
                name: "Dichvu");
        }
    }
}
