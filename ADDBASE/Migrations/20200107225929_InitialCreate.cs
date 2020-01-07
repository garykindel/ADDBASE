using Microsoft.EntityFrameworkCore.Migrations;

namespace ADDBASE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Key = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Item = table.Column<string>(nullable: true),
                    Cost = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    WeaponType = table.Column<string>(nullable: true),
                    SpeedFactor = table.Column<string>(nullable: true),
                    DamageXSmall = table.Column<string>(nullable: true),
                    DamageXLarge = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Key);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
