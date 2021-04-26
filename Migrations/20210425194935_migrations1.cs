using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRegistry.Migrations
{
    public partial class migrations1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarBrand = table.Column<string>(type: "varchar(250)", nullable: false),
                    CarModel = table.Column<string>(type: "varchar(250)", nullable: false),
                    EngineCapacity = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    EnginePower = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    NumberOfCylinders = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
