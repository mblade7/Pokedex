using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Migrations
{
    public partial class NewPokemon1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type2",
                table: "Pokemon",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type1",
                table: "Pokemon",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Moves",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 1, 49, 49, 45, 65, 45, 45, "フシギダネ", "Bulbasaur", "A strange seed was planted on its back at birth. The plant sprouts and grows with this Pokémon.", "Grass", "Poison", "It can go for days without eating a single morsel. In the bulb on its back, it stores energy." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 2, 62, 63, 60, 80, 60, 45, "フシギソウ", "Ivysaur", "A strange seed was planted on its back at birth. The plant sprouts and grows with this Pokémon.", "Grass", "Poison", "It can go for days without eating a single morsel. In the bulb on its back, it stores energy." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Type2",
                table: "Pokemon",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Type1",
                table: "Pokemon",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Moves",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
