﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Pokedex.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220717122543_UpdateMoveTable")]
    partial class UpdateMoveTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Moves", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Accuracy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Effect")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Power")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StartPP")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("Pokemon", b =>
                {
                    b.Property<int>("DexNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Base_ATK")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Base_DEF")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Base_HP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Base_SPC")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Base_SPD")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Catch_Rate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Japanese_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RedBlueDex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type2")
                        .HasColumnType("TEXT");

                    b.Property<string>("YellowDex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DexNum");

                    b.ToTable("Pokemon");

                    b.HasData(
                        new
                        {
                            DexNum = 1,
                            Base_ATK = 49,
                            Base_DEF = 49,
                            Base_HP = 45,
                            Base_SPC = 65,
                            Base_SPD = 45,
                            Catch_Rate = 45,
                            Japanese_Name = "フシギダネ",
                            Name = "Bulbasaur",
                            RedBlueDex = "A strange seed was planted on its back at birth. The plant sprouts and grows with this Pokémon.",
                            Type1 = "Grass",
                            Type2 = "Poison",
                            YellowDex = "It can go for days without eating a single morsel. In the bulb on its back, it stores energy."
                        },
                        new
                        {
                            DexNum = 2,
                            Base_ATK = 62,
                            Base_DEF = 63,
                            Base_HP = 60,
                            Base_SPC = 80,
                            Base_SPD = 60,
                            Catch_Rate = 45,
                            Japanese_Name = "フシギソウ",
                            Name = "Ivysaur",
                            RedBlueDex = "A strange seed was planted on its back at birth. The plant sprouts and grows with this Pokémon.",
                            Type1 = "Grass",
                            Type2 = "Poison",
                            YellowDex = "It can go for days without eating a single morsel. In the bulb on its back, it stores energy."
                        },
                        new
                        {
                            DexNum = 3,
                            Base_ATK = 82,
                            Base_DEF = 83,
                            Base_HP = 80,
                            Base_SPC = 100,
                            Base_SPD = 80,
                            Catch_Rate = 45,
                            Japanese_Name = "フシギバナ",
                            Name = "Venusaur",
                            RedBlueDex = "The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.",
                            Type1 = "Grass",
                            Type2 = "Poison",
                            YellowDex = "The flower on its back catches the sun's rays. The sunlight is then absorbed and used for energy."
                        },
                        new
                        {
                            DexNum = 4,
                            Base_ATK = 52,
                            Base_DEF = 43,
                            Base_HP = 39,
                            Base_SPC = 50,
                            Base_SPD = 65,
                            Catch_Rate = 45,
                            Japanese_Name = "ヒトカゲ",
                            Name = "Charmander",
                            RedBlueDex = "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.",
                            Type1 = "Fire",
                            YellowDex = "The flame at the tip of its tail makes a sound as it burns. You can only hear it in quiet places."
                        },
                        new
                        {
                            DexNum = 5,
                            Base_ATK = 64,
                            Base_DEF = 58,
                            Base_HP = 58,
                            Base_SPC = 65,
                            Base_SPD = 80,
                            Catch_Rate = 45,
                            Japanese_Name = "リザード",
                            Name = "Charmeleon",
                            RedBlueDex = "When it swings its burning tail, it elevates the temperature to unbearably high levels.",
                            Type1 = "Fire",
                            YellowDex = "Tough fights could excite this Pokémon. When excited, it may blow out bluish-white flames."
                        },
                        new
                        {
                            DexNum = 6,
                            Base_ATK = 84,
                            Base_DEF = 78,
                            Base_HP = 78,
                            Base_SPC = 85,
                            Base_SPD = 100,
                            Catch_Rate = 45,
                            Japanese_Name = "リザードン",
                            Name = "Charizard",
                            RedBlueDex = "Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally.",
                            Type1 = "Fire",
                            YellowDex = "When expelling a blast of super hot fire, the red flame at the tip of its tail burns more intensely."
                        },
                        new
                        {
                            DexNum = 7,
                            Base_ATK = 48,
                            Base_DEF = 65,
                            Base_HP = 44,
                            Base_SPC = 50,
                            Base_SPD = 43,
                            Catch_Rate = 45,
                            Japanese_Name = "ゼニガメ",
                            Name = "Squirtle",
                            RedBlueDex = "After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth.",
                            Type1 = "Water",
                            YellowDex = "Shoots water at prey while in the water. Withdraws into its shell when in danger."
                        },
                        new
                        {
                            DexNum = 8,
                            Base_ATK = 63,
                            Base_DEF = 80,
                            Base_HP = 59,
                            Base_SPC = 65,
                            Base_SPD = 58,
                            Catch_Rate = 45,
                            Japanese_Name = "カメール",
                            Name = "Wartortle",
                            RedBlueDex = "Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance.",
                            Type1 = "Water",
                            YellowDex = "When tapped, this Pokémon will pull in its head, but its tail will still stick out a little bit."
                        },
                        new
                        {
                            DexNum = 9,
                            Base_ATK = 83,
                            Base_DEF = 100,
                            Base_HP = 79,
                            Base_SPC = 85,
                            Base_SPD = 78,
                            Catch_Rate = 45,
                            Japanese_Name = "カメックス",
                            Name = "Blastoise",
                            RedBlueDex = "A brutal Pokémon with pressurized water jets on its shell. They are used for high speed tackles.",
                            Type1 = "Water",
                            YellowDex = "Once it takes aim at its enemy, it blasts out water with even more force than a fire hose."
                        },
                        new
                        {
                            DexNum = 10,
                            Base_ATK = 30,
                            Base_DEF = 35,
                            Base_HP = 45,
                            Base_SPC = 20,
                            Base_SPD = 45,
                            Catch_Rate = 255,
                            Japanese_Name = "キャタピー",
                            Name = "Caterpie",
                            RedBlueDex = "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.",
                            Type1 = "Bug",
                            YellowDex = "If you touch the feeler on top of its head, it will release a horrible stink to protect itself."
                        },
                        new
                        {
                            DexNum = 11,
                            Base_ATK = 20,
                            Base_DEF = 55,
                            Base_HP = 50,
                            Base_SPC = 25,
                            Base_SPD = 30,
                            Catch_Rate = 120,
                            Japanese_Name = "トランセル",
                            Name = "Metapod",
                            RedBlueDex = "This Pokémon is vulnerable to attack while its shell is soft, exposing its weak and tender body.",
                            Type1 = "Bug",
                            YellowDex = "	Hardens its shell to protect itself. However, a large impact may cause it to pop out of its shell."
                        },
                        new
                        {
                            DexNum = 12,
                            Base_ATK = 45,
                            Base_DEF = 50,
                            Base_HP = 60,
                            Base_SPC = 80,
                            Base_SPD = 75,
                            Catch_Rate = 45,
                            Japanese_Name = "バタフリー",
                            Name = "Butterfree",
                            RedBlueDex = "In battle, it flaps its wings at high speed to release highly toxic dust into the air.",
                            Type1 = "Bug",
                            Type2 = "Flying",
                            YellowDex = "Its wings, covered with poisonous powders, repel water. This allows it to fly in the rain."
                        },
                        new
                        {
                            DexNum = 13,
                            Base_ATK = 35,
                            Base_DEF = 30,
                            Base_HP = 40,
                            Base_SPC = 20,
                            Base_SPD = 50,
                            Catch_Rate = 255,
                            Japanese_Name = "ビードル",
                            Name = "Weedle",
                            RedBlueDex = "Often found in forests, eating leaves. It has a sharp venomous stinger on its head.",
                            Type1 = "Bug",
                            Type2 = "Poison",
                            YellowDex = "Beware of the sharp stinger on its head. It hides in grass and bushes where it eats leaves."
                        },
                        new
                        {
                            DexNum = 14,
                            Base_ATK = 25,
                            Base_DEF = 50,
                            Base_HP = 45,
                            Base_SPC = 25,
                            Base_SPD = 35,
                            Catch_Rate = 120,
                            Japanese_Name = "コクーン",
                            Name = "Kakuna",
                            RedBlueDex = "Almost incapable of moving, this Pokémon can only harden its shell to protect itself from predators.",
                            Type1 = "Bug",
                            Type2 = "Poison",
                            YellowDex = "Able to move only slightly. When endangered, it may stick out its stinger and poison its enemy."
                        },
                        new
                        {
                            DexNum = 15,
                            Base_ATK = 80,
                            Base_DEF = 40,
                            Base_HP = 65,
                            Base_SPC = 45,
                            Base_SPD = 75,
                            Catch_Rate = 45,
                            Japanese_Name = "スピアー",
                            Name = "Beedrill",
                            RedBlueDex = "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.",
                            Type1 = "Bug",
                            Type2 = "Poison",
                            YellowDex = "It has 3 poisonous stingers on its forelegs and its tail. They are used to jab its enemy repeatedly."
                        },
                        new
                        {
                            DexNum = 16,
                            Base_ATK = 45,
                            Base_DEF = 40,
                            Base_HP = 40,
                            Base_SPC = 35,
                            Base_SPD = 56,
                            Catch_Rate = 255,
                            Japanese_Name = "ポッポ",
                            Name = "Pidgey",
                            RedBlueDex = "A common sight in forests and woods. It flaps its wings at ground level to kick up blinding sand.",
                            Type1 = "Normal",
                            Type2 = "Flying",
                            YellowDex = "Very docile. If attacked, it will often kick up sand to protect itself rather than fight back."
                        },
                        new
                        {
                            DexNum = 17,
                            Base_ATK = 60,
                            Base_DEF = 55,
                            Base_HP = 63,
                            Base_SPC = 50,
                            Base_SPD = 71,
                            Catch_Rate = 120,
                            Japanese_Name = "ピジョン",
                            Name = "Pidgeotto",
                            RedBlueDex = "Very protective of its sprawling territorial area, this Pokémon will fiercely peck at any intruder.",
                            Type1 = "Normal",
                            Type2 = "Flying",
                            YellowDex = "This Pokémon is full of vitality. It constantly flies around its large territory in search of prey."
                        },
                        new
                        {
                            DexNum = 18,
                            Base_ATK = 80,
                            Base_DEF = 75,
                            Base_HP = 83,
                            Base_SPC = 70,
                            Base_SPD = 91,
                            Catch_Rate = 45,
                            Japanese_Name = "ピジョット",
                            Name = "Pidgeot",
                            RedBlueDex = "When hunting, it skims the surface of water at high speed to pick off unwary prey such as Magikarp.",
                            Type1 = "Normal",
                            Type2 = "Flying",
                            YellowDex = "This Pokémon flies at Mach 2 speed, seeking prey. Its large talons are feared as wicked weapons."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}