using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FriendsNess.Server.Migrations
{
    public partial class UpdateExercicies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExercicedBodyParts",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExercicedBodyParts",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExercicedBodyParts",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 5,
                column: "Category",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "ExercicedBodyParts" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "ExercicedBodyParts", "Name" },
                values: new object[] { 3, 1, "Dumbbell Curl" });

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "ExercicedBodyParts" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 10,
                column: "ExercicedBodyParts",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExercicedBodyParts",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExercicedBodyParts",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExercicedBodyParts",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 5,
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "ExercicedBodyParts" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "ExercicedBodyParts", "Name" },
                values: new object[] { 0, 0, "Bumbbell Curl" });

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "ExercicedBodyParts" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 10,
                column: "ExercicedBodyParts",
                value: 0);
        }
    }
}
