using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Migrations
{
    public partial class NewPokemon3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 5, 64, 58, 58, 65, 80, 45, "リザード", "Charmeleon", "When it swings its burning tail, it elevates the temperature to unbearably high levels.", "Fire", null, "Tough fights could excite this Pokémon. When excited, it may blow out bluish-white flames." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 6, 84, 78, 78, 85, 100, 45, "リザードン", "Charizard", "Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally.", "Fire", null, "When expelling a blast of super hot fire, the red flame at the tip of its tail burns more intensely." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 7, 48, 65, 44, 50, 43, 45, "ゼニガメ", "Squirtle", "After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth.", "Water", null, "Shoots water at prey while in the water. Withdraws into its shell when in danger." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 8, 63, 80, 59, 65, 58, 45, "カメール", "Wartortle", "Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance.", "Water", null, "When tapped, this Pokémon will pull in its head, but its tail will still stick out a little bit." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 9, 83, 100, 79, 85, 78, 45, "カメックス", "Blastoise", "A brutal Pokémon with pressurized water jets on its shell. They are used for high speed tackles.", "Water", null, "Once it takes aim at its enemy, it blasts out water with even more force than a fire hose." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 10, 30, 35, 45, 20, 45, 255, "キャタピー", "Caterpie", "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.", "Bug", null, "If you touch the feeler on top of its head, it will release a horrible stink to protect itself." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 11, 20, 55, 50, 25, 30, 120, "トランセル", "Metapod", "This Pokémon is vulnerable to attack while its shell is soft, exposing its weak and tender body.", "Bug", null, "	Hardens its shell to protect itself. However, a large impact may cause it to pop out of its shell." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 12, 45, 50, 60, 80, 75, 45, "バタフリー", "Butterfree", "In battle, it flaps its wings at high speed to release highly toxic dust into the air.", "Bug", "Flying", "Its wings, covered with poisonous powders, repel water. This allows it to fly in the rain." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 13, 35, 30, 40, 20, 50, 255, "ビードル", "Weedle", "Often found in forests, eating leaves. It has a sharp venomous stinger on its head.", "Bug", "Poison", "Beware of the sharp stinger on its head. It hides in grass and bushes where it eats leaves." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 14, 25, 50, 45, 25, 35, 120, "コクーン", "Kakuna", "Almost incapable of moving, this Pokémon can only harden its shell to protect itself from predators.", "Bug", "Poison", "Able to move only slightly. When endangered, it may stick out its stinger and poison its enemy." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 15, 80, 40, 65, 45, 75, 45, "スピアー", "Beedrill", "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.", "Bug", "Poison", "It has 3 poisonous stingers on its forelegs and its tail. They are used to jab its enemy repeatedly." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 16, 45, 40, 40, 35, 56, 255, "ポッポ", "Pidgey", "A common sight in forests and woods. It flaps its wings at ground level to kick up blinding sand.", "Normal", "Flying", "Very docile. If attacked, it will often kick up sand to protect itself rather than fight back." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 17, 60, 55, 63, 50, 71, 120, "ピジョン", "Pidgeotto", "Very protective of its sprawling territorial area, this Pokémon will fiercely peck at any intruder.", "Normal", "Flying", "This Pokémon is full of vitality. It constantly flies around its large territory in search of prey." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 18, 80, 75, 83, 70, 91, 45, "ピジョット", "Pidgeot", "When hunting, it skims the surface of water at high speed to pick off unwary prey such as Magikarp.", "Normal", "Flying", "This Pokémon flies at Mach 2 speed, seeking prey. Its large talons are feared as wicked weapons." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 18);
        }
    }
}
