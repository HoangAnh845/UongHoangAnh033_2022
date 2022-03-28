using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UongHoangAnh2022033.Migrations
{
    public partial class Creatable_UHA1033 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UHA1033",
                columns: table => new
                {
                    UHAID = table.Column<string>(type: "TEXT", nullable: false),
                    UHAName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    UHA = table.Column<bool>(type: "INTEGER", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UHA1033", x => x.UHAID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UHA1033");
        }
    }
}
