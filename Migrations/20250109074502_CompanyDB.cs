using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactMakeMyTripApp.Migrations
{
    /// <inheritdoc />
    public partial class CompanyDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Makemytrip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startlocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    endlocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makemytrip", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Makemytrip");
        }
    }
}
