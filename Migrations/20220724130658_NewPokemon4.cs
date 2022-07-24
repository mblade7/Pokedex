using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Migrations
{
    public partial class NewPokemon4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 19, 56, 35, 30, 25, 72, 255, "コラッタ", "Rattata", "Bites anything when it attacks. Small and very quick, it is a common sight in many places.", "Normal", null, "Will chew on anything with its fangs. If you see one, it is certain that 40 more live in the area." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 20, 81, 60, 55, 50, 97, 127, "ラッタ", "Raticate", "It uses its whiskers to maintain its balance. It apparently slows down if they are cut off.", "Normal", null, "Its hind feet are webbed. They act as flippers, so it can swim in rivers and hunt for prey." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 21, 60, 30, 40, 31, 70, 255, "オニスズメ", "Spearow", "Eats bugs in grassy areas. It has to flap its short wings at high speed to stay airborne.", "Normal", "Flying", "Inept at flying high. However, it can fly around very fast to protect its territory." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 22, 90, 65, 65, 61, 100, 90, "オニドリル", "Fearow", "With its huge and magnificent wings, it can keep aloft without ever having to land for rest.", "Normal", "Flying", "A Pokémon that dates back many years. If it senses danger, it flies high and away, instantly." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 23, 60, 44, 35, 40, 55, 255, "アーボ", "Ekans", "Moves silently and stealthily. Eats the eggs of birds, such as Pidgey and Spearow, whole.", "Poison", null, "The older it gets, the longer it grows. At night, it wraps its long body around tree branches to rest." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 24, 85, 69, 60, 65, 80, 90, "アーボック", "Arbok", "It is rumored that the ferocious warning markings on its belly differ from area to area.", "Poison", null, "The frightening patterns on its belly have been studied. Six variations have been confirmed." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 25, 55, 30, 35, 50, 90, 190, "ピカチュウ", "Pikachu", "When several of these Pokémon gather, their electricity could build and cause lightning storms.", "Electric", null, "It keeps its tail raised to monitor its surroundings. If you yank its tail, it will try to bite you." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 26, 90, 55, 60, 90, 100, 75, "ライチュウ", "Raichu", "Its long tail serves as a ground to protect itself from its own high voltage power.", "Electric", null, "When electricity builds up inside its body, it becomes feisty. It also glows in the dark." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 27, 75, 85, 50, 30, 40, 255, "サンド", "Sandshrew", "Burrows deep underground in arid locations far from water. It only emerges to hunt for food.", "Ground", null, "Its body is dry. When it gets cold at night, its hide is said to become coated with a fine dew." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 28, 100, 110, 75, 55, 65, 90, "サンドパン", "Sandslash", "Curls up into a spiny ball when threatened. It can roll while curled up to attack or escape.", "Ground", null, "It is skilled at slashing enemies with its claws. If broken, they start to grow back in a day." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 29, 47, 52, 55, 40, 41, 235, "ニドラン♀", "Nidoran♀", "Although small, its venomous barbs render this Pokémon dangerous. The female has smaller horns.", "Poison", null, "A mild-mannered Pokémon that does not like to fight. Beware, its small horns secrete venom." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 30, 62, 67, 70, 55, 56, 120, "ニドリーナ", "Nidorina", "The female's horn develops slowly. Prefers physical attacks such as clawing and biting.", "Poison", null, "When resting deep in its burrow, its thorns always retract. This is proof that it is relaxed." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 31, 82, 87, 90, 75, 76, 45, "ニドクイン", "Nidoqueen", "Its hard scales provide strong protection. It uses its hefty bulk to execute powerful moves.", "Poison", "Ground", "Tough scales cover the sturdy body of this Pokémon. It appears that the scales grow in cycles." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 32, 57, 40, 46, 40, 50, 235, "“ニドラン♂", "Nidoran♂", "Stiffens its ears to sense danger. The larger its horns, the more powerful its secreted venom.", "Poison", null, "Its large ears are always kept upright. If it senses danger, it will attack with a poisonous sting." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 33, 72, 57, 61, 55, 65, 120, "“ニドリーノ", "Nidorino", "An aggressive Pokémon that is quick to attack. The horn on its head secretes a powerful venom.", "Poison", null, "Its horns contain venom. If they are stabbed into an enemy, the impact makes the poison leak out." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 34, 92, 77, 81, 75, 85, 45, "“ニドキング", "Nidoking", "It uses its powerful tail in battle to smash, constrict, then break the prey's bones.", "Poison", "Ground", "Its steel-like hide adds to its powerful tackle. Its horns are so hard, they can pierce a diamond." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 35, 45, 48, 70, 60, 35, 150, "ピッピ", "Clefairy", "Its magical and cute appeal has many admirers. It is rare and found only in certain areas.", "Normal", null, "Adored for their cute looks and playfulness. They are thought to be rare, as they do not appear often." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 36, 70, 73, 95, 85, 60, 25, "ピクシー", "Clefable", "Its magical and cute appeal has many admirers. It is rare and found only in certain areas.", "Normal", null, "Adored for their cute looks and playfulness. They are thought to be rare, as they do not appear often." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 37, 41, 40, 38, 65, 65, 190, "ロコン", "Vulpix", "At the time of birth, it has just one tail. The tail splits from its tip as it grows older.", "Fire", null, "Both its fur and its tails are beautiful. As it grows, the tails split and form more tails." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 38, 76, 75, 73, 100, 100, 75, "キュウコン", "Ninetales", "Very smart and very vengeful. Grabbing one of its many tails could result in a 1000-year curse.", "Fire", null, "According to an enduring legend, 9 noble saints were united and reincarnated as this Pokémon." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 39, 45, 20, 115, 25, 20, 170, "プリン", "Jigglypuff", "When its huge eyes light up, it sings a mysteriously soothing melody that lulls its enemies to sleep.", "Normal", null, "Uses its alluring eyes to enrapture its foe. It then sings a pleasing melody that lulls the foe to sleep." });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "DexNum", "Base_ATK", "Base_DEF", "Base_HP", "Base_SPC", "Base_SPD", "Catch_Rate", "Japanese_Name", "Name", "RedBlueDex", "Type1", "Type2", "YellowDex" },
                values: new object[] { 40, 70, 45, 140, 50, 45, 50, "プクリン", "Wigglytuff", "The body is soft and rubbery. When angered, it will suck in air and inflate itself to an enormous size.", "Normal", null, "Its body is full of elasticity. By inhaling deeply, it can continue to inflate itself without limit." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "DexNum",
                keyValue: 40);
        }
    }
}
