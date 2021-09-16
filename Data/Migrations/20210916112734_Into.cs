using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCMedicineShopProjectFinal.Data.Migrations
{
    public partial class Into : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CustomerAddress = table.Column<string>(nullable: true),
                    Time_at = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Enterpriser",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedName = table.Column<string>(nullable: true),
                    MedDescription = table.Column<string>(nullable: true),
                    MedAddress = table.Column<string>(nullable: true),
                    Time_at = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Enterpriser", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Medical_Enterpriser");
        }
    }
}
