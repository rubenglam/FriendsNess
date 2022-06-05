using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FriendsNess.Data.Migrations
{
    public partial class ExerciceSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciceSet_UserExercices_UserExerciceUserId_UserExerciceExe~",
                table: "ExerciceSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciceSet",
                table: "ExerciceSet");

            migrationBuilder.RenameTable(
                name: "ExerciceSet",
                newName: "ExerciceSets");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciceSet_UserExerciceUserId_UserExerciceExerciceId",
                table: "ExerciceSets",
                newName: "IX_ExerciceSets_UserExerciceUserId_UserExerciceExerciceId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciceSets",
                table: "ExerciceSets",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Plannings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plannings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plannings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PlanningExerciceSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Completed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ExerciceSetId = table.Column<int>(type: "int", nullable: false),
                    PlanningId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanningExerciceSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanningExerciceSets_ExerciceSets_ExerciceSetId",
                        column: x => x.ExerciceSetId,
                        principalTable: "ExerciceSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanningExerciceSets_Plannings_PlanningId",
                        column: x => x.PlanningId,
                        principalTable: "Plannings",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_PlanningExerciceSets_ExerciceSetId",
                table: "PlanningExerciceSets",
                column: "ExerciceSetId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanningExerciceSets_PlanningId",
                table: "PlanningExerciceSets",
                column: "PlanningId");

            migrationBuilder.CreateIndex(
                name: "IX_Plannings_UserId",
                table: "Plannings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciceSets_UserExercices_UserExerciceUserId_UserExerciceEx~",
                table: "ExerciceSets",
                columns: new[] { "UserExerciceUserId", "UserExerciceExerciceId" },
                principalTable: "UserExercices",
                principalColumns: new[] { "UserId", "ExerciceId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciceSets_UserExercices_UserExerciceUserId_UserExerciceEx~",
                table: "ExerciceSets");

            migrationBuilder.DropTable(
                name: "PlanningExerciceSets");

            migrationBuilder.DropTable(
                name: "Plannings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciceSets",
                table: "ExerciceSets");

            migrationBuilder.RenameTable(
                name: "ExerciceSets",
                newName: "ExerciceSet");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciceSets_UserExerciceUserId_UserExerciceExerciceId",
                table: "ExerciceSet",
                newName: "IX_ExerciceSet_UserExerciceUserId_UserExerciceExerciceId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciceSet",
                table: "ExerciceSet",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciceSet_UserExercices_UserExerciceUserId_UserExerciceExe~",
                table: "ExerciceSet",
                columns: new[] { "UserExerciceUserId", "UserExerciceExerciceId" },
                principalTable: "UserExercices",
                principalColumns: new[] { "UserId", "ExerciceId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
