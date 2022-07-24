using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Migrations
{
    public partial class NewMoves1Retry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 1, 100, "User recovers half the HP inflicted on opponent.", "Absorb", 20, 20, "Grass" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "ID", "Accuracy", "Effect", "Name", "Power", "StartPP", "Type" },
                values: new object[] { 2, 100, "Has a 33% chance to lower the target's Defense by 1 stage.", "Acid", 40, 30, "Poison" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
