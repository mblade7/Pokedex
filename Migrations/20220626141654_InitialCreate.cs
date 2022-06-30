using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    DexNum = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Japanese_Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type1 = table.Column<string>(type: "TEXT", nullable: false),
                    Type2 = table.Column<string>(type: "TEXT", nullable: true),
                    Base_HP = table.Column<int>(type: "INTEGER", nullable: false),
                    Base_ATK = table.Column<int>(type: "INTEGER", nullable: false),
                    Base_DEF = table.Column<int>(type: "INTEGER", nullable: false),
                    Base_SPC = table.Column<int>(type: "INTEGER", nullable: false),
                    Base_SPD = table.Column<int>(type: "INTEGER", nullable: false),
                    Catch_Rate = table.Column<int>(type: "INTEGER", nullable: false),
                    RedBlueDex = table.Column<string>(type: "TEXT", nullable: false),
                    YellowDex = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.DexNum);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon");
        }
    }
}
