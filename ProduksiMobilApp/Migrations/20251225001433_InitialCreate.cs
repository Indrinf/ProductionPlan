using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProduksiMobilApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductionPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Senin = table.Column<int>(type: "int", nullable: false),
                    Selasa = table.Column<int>(type: "int", nullable: false),
                    Rabu = table.Column<int>(type: "int", nullable: false),
                    Kamis = table.Column<int>(type: "int", nullable: false),
                    Jumat = table.Column<int>(type: "int", nullable: false),
                    Sabtu = table.Column<int>(type: "int", nullable: false),
                    Minggu = table.Column<int>(type: "int", nullable: false),
                    FixSenin = table.Column<int>(type: "int", nullable: false),
                    FixSelasa = table.Column<int>(type: "int", nullable: false),
                    FixRabu = table.Column<int>(type: "int", nullable: false),
                    FixKamis = table.Column<int>(type: "int", nullable: false),
                    FixJumat = table.Column<int>(type: "int", nullable: false),
                    FixSabtu = table.Column<int>(type: "int", nullable: false),
                    FixMinggu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionPlans", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductionPlans");
        }
    }
}
