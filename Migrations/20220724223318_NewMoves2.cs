using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Migrations
{
    public partial class NewMoves2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 3, 100, "Raises the user's Defense by 2 stages.", "Acid Armor", 0, 40, "Poison" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 4, 100, "Raises the user's Speed by 2 stages.", "Agility", 0, 30, "Psychic" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 5, 100, "Raises the user's Special by 2 stages.", "Amnesia", 0, 20, "Psychic" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 6, 100, "Has a 33% chance to lower the target's Attack by 1 stage.", "Aurora Beam", 65, 20, "Ice" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 7, 85, "Hits two to five times. Has a 3/8 chance to hit two or three times, and a 1/8 chance to hit four or five times. Damage is calculated once for the first hit and used for every hit. If one of the hits breaks the target's substitute, the move ends.", "Barrage", 15, 20, "Normal" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 8, 100, "Raises the user's Defense by 2 stages.", "Barrier", 0, 30, "Psychic" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 9, 100, "The user spends two to three turns locked into this move and then, on the second or third turn after using this move, the user attacks the opponent, inflicting double the damage in HP it lost during those turns. This move ignores type immunity and cannot be avoided even if the target is using Dig or Fly. The user can choose to switch out during the effect. If the user switches out or is prevented from moving during this move's use, the effect ends. During the effect, if the opposing Pokemon switched out or uses Confuse Ray, Conversion, Focus Energy, Glare, Haze, Leech Seed, Light Screen, Mimic, Mist, Poison Gas, Poison Powder, Recover, Reflect, Rest, Soft-Boiled, Splash, Stun Spore, Substitute, Supersonic, Teleport, Thunder Wave, Toxic, or Transform, the previous damage dealt to the user will be added to the total.", "Bide", 0, 10, "Normal" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 10, 85, "The user spends two to five turns using this move. Has a 3/8 chance to last two or three turns, and a 1/8 chance to last four or five turns. The damage calculated for the first turn is used for every other turn. The user cannot select a move and the target cannot execute a move during the effect, but both may switch out. If the user switches out, the target remains unable to execute a move during that turn. If the target switches out, the user uses this move automatically, and if it had 0 PP at the time, it becomes 63. If the user or the target switches out, or the user is prevented from moving, the effect ends. This move can prevent the target from moving even if it has type immunity but will not deal damage", "Bind", 15, 20, "Normal" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 11, 100, "Has a 10% chance to make the target flinch.", "Bite", 60, 25, "Normal" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 12, 90, "Has a 10% chance to freeze the target.", "Blizzard", 120, 5, "Ice" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 13, 100, "Has a 30% chance to paralyze the target.", "Body Slam", 85, 15, "Normal" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 14, 85, "Has a 10% chance to make the target flinch.", "Bone Club", 65, 20, "Ground" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 15, 90, "Hits twice. If the first hit breaks the target's substitute, the move ends.", "Bonemerang", 50, 10, "Ground" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 16, 100, "Has a 33% chance to lower the target's Speed by 1 stage.", "Bubble", 20, 30, "Water" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 17, 100, "Has a 33% chance to lower the target's Speed by 1 stage.", "Bubble Beam", 65, 20, "Water" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 18, 75, "The user spends two to five turns using this move. Has a 3/8 chance to last two or three turns, and a 1/8 chance to last four or five turns. The damage calculated for the first turn is used for every other turn. The user cannot select a move and the target cannot execute a move during the effect, but both may switch out. If the user switches out, the target remains unable to execute a move during that turn. If the target switches out, the user uses this move automatically, and if it had 0 PP at the time, it becomes 63. If the user or the target switches out, or the user is prevented from moving, the effect ends. This move can prevent the target from moving even if it has type immunity but will not deal damage", "Clamp", 35, 10, "Water" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 19, 85, "Hits two to five times. Has a 3/8 chance to hit two or three times, and a 1/8 chance to hit four or five times. Damage is calculated once for the first hit and used for every hit. If one of the hits breaks the target's substitute, the move ends.", "Comet Punch", 18, 15, "Normal" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 20, 100, "Causes the target to become confused.", "Confuse Ray", 0, 10, "Ghost" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 20);
        }
    }
}
