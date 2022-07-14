using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Migrations
{
    public partial class NewPokemon2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 3, 82, 83, 80, 100, 80, 45, "フシギバナ", "Venusaur", "The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.", "Grass", "Poison", "The flower on its back catches the sun's rays. The sunlight is then absorbed and used for energy." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 4, 52, 43, 39, 50, 65, 45, "ヒトカゲ", "Charmander", "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.", "Fire", null, "The flame at the tip of its tail makes a sound as it burns. You can only hear it in quiet places." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 4);
        }
    }
}
