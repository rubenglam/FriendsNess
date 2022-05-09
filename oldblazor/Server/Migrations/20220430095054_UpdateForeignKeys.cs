using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FriendsNess.Server.Migrations
{
    public partial class UpdateForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciceSet_UserExercice_UserExerciceUserId_UserExerciceExer~",
                table: "ExerciceSet");

            migrationBuilder.DropForeignKey(
                name: "FK_UserExercice_AspNetUsers_UserId",
                table: "UserExercice");

            migrationBuilder.DropForeignKey(
                name: "FK_UserExercice_Exercice_ExerciceId",
                table: "UserExercice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserExercice",
                table: "UserExercice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exercice",
                table: "Exercice");

            migrationBuilder.RenameTable(
                name: "UserExercice",
                newName: "UserExercices");

            migrationBuilder.RenameTable(
                name: "Exercice",
                newName: "Exercices");

            migrationBuilder.RenameIndex(
                name: "IX_UserExercice_ExerciceId",
                table: "UserExercices",
                newName: "IX_UserExercices_ExerciceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserExercices",
                table: "UserExercices",
                columns: new[] { "UserId", "ExerciceId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exercices",
                table: "Exercices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciceSet_UserExercices_UserExerciceUserId_UserExerciceExe~",
                table: "ExerciceSet",
                columns: new[] { "UserExerciceUserId", "UserExerciceExerciceId" },
                principalTable: "UserExercices",
                principalColumns: new[] { "UserId", "ExerciceId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserExercices_AspNetUsers_UserId",
                table: "UserExercices",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserExercices_Exercices_ExerciceId",
                table: "UserExercices",
                column: "ExerciceId",
                principalTable: "Exercices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciceSet_UserExercices_UserExerciceUserId_UserExerciceExe~",
                table: "ExerciceSet");

            migrationBuilder.DropForeignKey(
                name: "FK_UserExercices_AspNetUsers_UserId",
                table: "UserExercices");

            migrationBuilder.DropForeignKey(
                name: "FK_UserExercices_Exercices_ExerciceId",
                table: "UserExercices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserExercices",
                table: "UserExercices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exercices",
                table: "Exercices");

            migrationBuilder.RenameTable(
                name: "UserExercices",
                newName: "UserExercice");

            migrationBuilder.RenameTable(
                name: "Exercices",
                newName: "Exercice");

            migrationBuilder.RenameIndex(
                name: "IX_UserExercices_ExerciceId",
                table: "UserExercice",
                newName: "IX_UserExercice_ExerciceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserExercice",
                table: "UserExercice",
                columns: new[] { "UserId", "ExerciceId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exercice",
                table: "Exercice",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciceSet_UserExercice_UserExerciceUserId_UserExerciceExer~",
                table: "ExerciceSet",
                columns: new[] { "UserExerciceUserId", "UserExerciceExerciceId" },
                principalTable: "UserExercice",
                principalColumns: new[] { "UserId", "ExerciceId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserExercice_AspNetUsers_UserId",
                table: "UserExercice",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserExercice_Exercice_ExerciceId",
                table: "UserExercice",
                column: "ExerciceId",
                principalTable: "Exercice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
