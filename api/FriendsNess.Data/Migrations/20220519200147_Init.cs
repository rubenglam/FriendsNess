using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FriendsNess.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeviceCode = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubjectId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SessionId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Data = table.Column<string>(type: "longtext", maxLength: 50000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Exercices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    BodyPart = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercices", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Use = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Algorithm = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsX509Certificate = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DataProtected = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Data = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubjectId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SessionId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Data = table.Column<string>(type: "longtext", maxLength: 50000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserExercices",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ExerciceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserExercices", x => new { x.UserId, x.ExerciceId });
                    table.ForeignKey(
                        name: "FK_UserExercices_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserExercices_Exercices_ExerciceId",
                        column: x => x.ExerciceId,
                        principalTable: "Exercices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExerciceSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Weight = table.Column<double>(type: "double", nullable: false),
                    Repetitions = table.Column<int>(type: "int", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    UserExerciceId = table.Column<int>(type: "int", nullable: false),
                    UserExerciceUserId = table.Column<int>(type: "int", nullable: false),
                    UserExerciceExerciceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciceSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciceSet_UserExercices_UserExerciceUserId_UserExerciceExe~",
                        columns: x => new { x.UserExerciceUserId, x.UserExerciceExerciceId },
                        principalTable: "UserExercices",
                        principalColumns: new[] { "UserId", "ExerciceId" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Exercices",
                columns: new[] { "Id", "BodyPart", "Category", "Image", "Name" },
                values: new object[,]
                {
                    { 1, 2, 0, null, "Bench Press" },
                    { 2, 5, 0, null, "Squat" },
                    { 3, 8, 0, null, "Deadlift" },
                    { 4, 6, 0, null, "Shoulder Press" },
                    { 5, 0, 1, null, "Pull Ups" },
                    { 6, 2, 3, null, "Dumbbell Bench Press" },
                    { 7, 1, 3, null, "Dumbbell Curl" },
                    { 8, 0, 0, null, "Bent Over Row" },
                    { 9, 2, 1, null, "Push Ups" },
                    { 10, 5, 0, null, "Front Squat" },
                    { 11, 6, 3, null, "Dumbbell Shoulder Press" },
                    { 12, 5, 4, null, "Sled Leg Press" },
                    { 13, 2, 0, null, "Incline Bench Press" },
                    { 14, 7, 1, null, "Dips" },
                    { 15, 8, 5, null, "Power Clean" },
                    { 16, 0, 2, null, "Lat Pulldown" },
                    { 17, 2, 3, null, "Incline Dumbbell Bench Press" },
                    { 18, 8, 0, null, "Hex Bar Deadlift" },
                    { 19, 6, 0, null, "Military Press" },
                    { 20, 0, 1, null, "Chin Ups" },
                    { 21, 8, 0, null, "Sumo Deadlift" },
                    { 22, 0, 3, null, "Dumbbell Row" },
                    { 23, 5, 4, null, "Horizontal Leg Press" },
                    { 24, 5, 0, null, "Hip Thrust" },
                    { 25, 6, 3, null, "Dumbbell Lateral Raise" },
                    { 26, 8, 3, null, "Romanian Deadlift" },
                    { 27, 5, 4, null, "Leg Extension" },
                    { 28, 2, 4, null, "Chest Press" },
                    { 29, 8, 5, null, "Clean and Jerk" },
                    { 30, 7, 2, null, "Tricep Pushdown" },
                    { 31, 8, 5, null, "Snatch" },
                    { 32, 8, 5, null, "Clean" },
                    { 33, 0, 2, null, "Seated Cable Row" },
                    { 34, 1, 3, null, "Hammer Curl" },
                    { 35, 6, 5, null, "Push Press" },
                    { 36, 0, 0, null, "Barbell Shrug" },
                    { 37, 2, 0, null, "Decline Bench Press" },
                    { 38, 2, 0, null, "Close Grip Bench Press" },
                    { 39, 8, 5, null, "Clean and Press" },
                    { 40, 5, 4, null, "Seated Leg Curl" },
                    { 41, 2, 3, null, "Dumbbell Fly" },
                    { 42, 0, 0, null, "T Bar Row" },
                    { 43, 5, 4, null, "Machine Calf Raise" },
                    { 44, 5, 4, null, "Lying Leg Curl" },
                    { 45, 5, 3, null, "Dumbbell Lunge" },
                    { 46, 1, 0, null, "EZ Bar Curl" },
                    { 47, 7, 2, null, "Tricep Rope Pushdown" },
                    { 48, 0, 3, null, "Dumbbell Shrug" },
                    { 49, 7, 0, null, "Lying Tricep Extension" },
                    { 50, 6, 0, null, "Seated Shoulder Press" },
                    { 51, 5, 3, null, "Goblet Squat" },
                    { 52, 7, 3, null, "Dumbbell Tricep Extension" },
                    { 53, 8, 0, null, "Rack Pull" },
                    { 54, 1, 3, null, "Preacher Curl" },
                    { 55, 5, 4, null, "Vertical Leg Press" },
                    { 56, 0, 0, null, "Pendlay Row" },
                    { 57, 5, 3, null, "Dumbbell Bulgarian Split Squat" },
                    { 58, 6, 4, null, "Machine Shoulder Press" },
                    { 59, 2, 4, null, "Machine Chest Fly" },
                    { 60, 6, 0, null, "Upright Row" },
                    { 61, 7, 0, null, "Tricep Extension" },
                    { 62, 5, 0, null, "Box Squat" },
                    { 63, 6, 3, null, "Dumbbell Front Raise" },
                    { 64, 5, 4, null, "Hack Squat" },
                    { 65, 1, 3, null, "Dumbbell Concentration Curl" },
                    { 66, 1, 2, null, "Cable Bicep Curl" },
                    { 67, 3, 1, null, "Sit Ups" },
                    { 68, 6, 2, null, "Cable Lateral Raise" },
                    { 69, 2, 3, null, "Arnold Press" },
                    { 70, 5, 1, null, "Bodyweight Squat" },
                    { 71, 5, 0, null, "Bulgarian Split Squat" },
                    { 72, 2, 0, null, "Floor Press" },
                    { 73, 2, 3, null, "Incline Dumbbell Fly" },
                    { 74, 0, 0, null, "Good Morning" },
                    { 75, 0, 0, null, "Cable Fly" },
                    { 76, 0, 0, null, "Hang Clean" },
                    { 77, 0, 0, null, "Seated Calf Raise" },
                    { 78, 0, 0, null, "Muscle Ups" },
                    { 79, 0, 0, null, "Stiff Leg Deadlift" },
                    { 80, 0, 0, null, "Barbell Lunge" },
                    { 81, 0, 0, null, "Zercher Squat" },
                    { 82, 0, 0, null, "Dumbbell Romanian Deadlift" },
                    { 83, 0, 0, null, "Overhead Squat" },
                    { 84, 0, 0, null, "Dumbbell Pullover" },
                    { 85, 0, 0, null, "Cable Crunch" },
                    { 86, 0, 0, null, "Lying Dumbbell Tricep Extension" },
                    { 87, 0, 0, null, "Smite Machine Bench Press" },
                    { 88, 0, 0, null, "Face Pull" },
                    { 89, 0, 0, null, "Hip Abduction" },
                    { 90, 0, 0, null, "Incline Dumbbell Curl" },
                    { 91, 0, 0, null, "Dumbbell Floor Press" },
                    { 92, 0, 0, null, "Thruster" },
                    { 93, 0, 0, null, "Dumbbell Reverse Fly" },
                    { 94, 0, 0, null, "Machine Row" },
                    { 95, 0, 0, null, "Push Jerk" },
                    { 96, 0, 0, null, "Wrist Curl" },
                    { 97, 0, 0, null, "Smith Machine Squat" },
                    { 98, 0, 0, null, "Power Snatch" },
                    { 99, 0, 0, null, "Hip Adduction" },
                    { 100, 0, 0, null, "Dumbbell Tricep Kickback" },
                    { 101, 0, 0, null, "Chest Supported Dumbbell Row" },
                    { 102, 0, 0, null, "Decline Dumbbell Bench Press" },
                    { 103, 0, 0, null, "Split Squat" },
                    { 104, 0, 0, null, "Seated Dip Machine" },
                    { 105, 0, 0, null, "Machine Seated Crunch" },
                    { 106, 0, 0, null, "Cable Pull Through" },
                    { 107, 0, 0, null, "Reverse Grip Bench Press" },
                    { 108, 0, 0, null, "Crunches" },
                    { 109, 0, 0, null, "Reverse Wrist Curl" },
                    { 110, 0, 0, null, "Landmine Squat" },
                    { 111, 0, 0, null, "Standing Leg Curl" },
                    { 112, 0, 0, null, "Barbell Calf Raise" },
                    { 113, 0, 0, null, "Reverse Barbell Curl" },
                    { 114, 0, 0, null, "One Arm Cable Bicep Curl" },
                    { 115, 0, 0, null, "Dumbbell Squat" },
                    { 116, 0, 0, null, "Barbell Glute Bridge" },
                    { 117, 0, 0, null, "Barbell Reverse Lunge" },
                    { 118, 0, 0, null, "Deficit Deadlift" },
                    { 119, 0, 0, null, "Dumbbell Calf Raise" },
                    { 120, 0, 0, null, "Cable Crossover" },
                    { 121, 0, 0, null, "Machine Tricep Extension" },
                    { 122, 0, 0, null, "Paused Bench Press" },
                    { 123, 0, 0, null, "One Arm Push Ups" },
                    { 124, 0, 0, null, "Close Grip Lat Pulldown" },
                    { 125, 0, 0, null, "Neck Curl" },
                    { 126, 0, 0, null, "Dumbbell Deadlift" },
                    { 127, 0, 0, null, "Strict Curl" },
                    { 128, 0, 0, null, "Cable Reverse Fly" },
                    { 129, 0, 0, null, "Cable Overhead Tricep Extension" },
                    { 130, 0, 0, null, "Belt Squat" },
                    { 131, 0, 0, null, "Dumbbell Upright Row" },
                    { 132, 0, 0, null, "Barbell Hack Squat" },
                    { 133, 0, 0, null, "Safety Bar Squat" },
                    { 134, 0, 0, null, "Machine Bicep Curl" },
                    { 135, 0, 0, null, "Machine Reverse Fly" },
                    { 136, 0, 0, null, "Behind The Neck Press" },
                    { 137, 0, 0, null, "Bench Pin Press" },
                    { 138, 0, 0, null, "Dumbbell Wrist Curl" },
                    { 139, 0, 0, null, "Barbell Front Raise" },
                    { 140, 0, 0, null, "Clean High Pull" },
                    { 141, 0, 0, null, "Single Leg Press" },
                    { 142, 0, 0, null, "Close Grip Dumbbell Bench Press" },
                    { 143, 0, 0, null, "Long Press" },
                    { 144, 0, 0, null, "Reverse Grip Lat Pulldown" },
                    { 145, 0, 0, null, "Bench Pull" },
                    { 146, 0, 0, null, "Pause Squat" },
                    { 147, 0, 0, null, "Handstand Push Ups" },
                    { 148, 0, 0, null, "Diamond Push Ups" },
                    { 149, 0, 0, null, "Single Leg Romanian Deadlift" },
                    { 150, 0, 0, null, "Sled Press Calf Raise" },
                    { 151, 0, 0, null, "Cable Woodchoppers" },
                    { 152, 0, 0, null, "Clean Pull" },
                    { 153, 0, 0, null, "Split Jerk" },
                    { 154, 0, 0, null, "Straight Arm Pulldown" },
                    { 155, 0, 0, null, "Sumo Squat" },
                    { 156, 0, 0, null, "Incline Hammer Curl" },
                    { 157, 0, 0, null, "Snatch Deadlift" },
                    { 158, 0, 0, null, "Dumbbell Preacher Curl" },
                    { 159, 0, 0, null, "Dumbbell Side Bend" },
                    { 160, 0, 0, null, "Machine Back Extension" },
                    { 161, 0, 0, null, "Burpees" },
                    { 162, 0, 0, null, "Hang Power Clean" },
                    { 163, 0, 0, null, "Yates Row" },
                    { 164, 0, 0, null, "Jefferson Deadlift" },
                    { 165, 0, 0, null, "Barbell Pullover" },
                    { 166, 0, 0, null, "Dumbbell Snatch" },
                    { 167, 0, 0, null, "Single Leg Deadlift" },
                    { 168, 0, 0, null, "Pause Deadlift" },
                    { 169, 0, 0, null, "Machine Lateral Raise" },
                    { 170, 0, 0, null, "Landmine Press" },
                    { 171, 0, 0, null, "Muscle Snatch" },
                    { 172, 0, 0, null, "Wide Grip Bench Press" },
                    { 173, 0, 0, null, "Seated Dumbbell Shoulder Press" },
                    { 174, 0, 0, null, "Reverse Grip Tricep Pushdown" },
                    { 175, 0, 0, null, "Dumbbell Bench Pull" },
                    { 176, 0, 0, null, "Cable Kickback" },
                    { 177, 0, 0, null, "Neck Extension" },
                    { 178, 0, 0, null, "Z Press" },
                    { 179, 0, 0, null, "Reverse Curl" },
                    { 180, 0, 0, null, "Renegade Row" },
                    { 181, 0, 0, null, "Shoulder Pin Press" },
                    { 182, 0, 0, null, "Zottman Curl" },
                    { 183, 0, 0, null, "Viking Press" },
                    { 184, 0, 0, null, "Neutral Grip Pull Ups" },
                    { 185, 0, 0, null, "Tate Press" },
                    { 186, 0, 0, null, "Lunge" },
                    { 187, 0, 0, null, "Snatch Pull" },
                    { 188, 0, 0, null, "Spider Curl" },
                    { 189, 0, 0, null, "Dumbbell Z Press" },
                    { 190, 0, 0, null, "JM Press" },
                    { 191, 0, 0, null, "Pin Squat" },
                    { 192, 0, 0, null, "One Arm Pull Ups" },
                    { 193, 0, 0, null, "Wall Ball" },
                    { 194, 0, 0, null, "Glute Bridge" },
                    { 195, 0, 0, null, "Back Extension" },
                    { 196, 0, 0, null, "Pistol Squat" },
                    { 197, 0, 0, null, "Hanging Leg Raise" },
                    { 198, 0, 0, null, "Inverted Row" },
                    { 199, 0, 0, null, "Russian Twist" },
                    { 200, 0, 0, null, "Bent Over Dumbbell Row" },
                    { 201, 0, 0, null, "Bodyweight Calf Raise" },
                    { 202, 0, 0, null, "Lying Leg Raise" },
                    { 203, 0, 0, null, "Seated Dumbbell Tricep Extension" },
                    { 204, 0, 0, null, "Bench Dips" },
                    { 205, 0, 0, null, "Ring Dips" },
                    { 206, 0, 0, null, "Toes To Bar" },
                    { 207, 0, 0, null, "Cheat Curl" },
                    { 208, 0, 0, null, "Seated Dumbbell Curl" },
                    { 209, 0, 0, null, "Dumbbell Front Squat" },
                    { 210, 0, 0, null, "Walking Lung" },
                    { 211, 0, 0, null, "Decline Push Ups" },
                    { 212, 0, 0, null, "Ab Wheel Rollout" },
                    { 213, 0, 0, null, "Reverse Lunge" },
                    { 214, 0, 0, null, "Dumbbell Reverse Wrist Curl" },
                    { 215, 0, 0, null, "Hanging Knee Raise" },
                    { 216, 0, 0, null, "Glute Ham Raise" },
                    { 217, 0, 0, null, "Nordic Hamstring Curl" },
                    { 218, 0, 0, null, "Decline Crunch" },
                    { 219, 0, 0, null, "Close Grip Push Up" },
                    { 220, 0, 0, null, "Decline Sit Up" },
                    { 221, 0, 0, null, "Jumping Jack" },
                    { 222, 0, 0, null, "Squat Jumps" },
                    { 223, 0, 0, null, "Dumbbell Push Press" },
                    { 224, 0, 0, null, "Incline Push Up" },
                    { 225, 0, 0, null, "Dumbbell External Rotation" },
                    { 226, 0, 0, null, "One Arm Seated Cable Row" },
                    { 227, 0, 0, null, "Cable Upright Row" },
                    { 228, 0, 0, null, "Pike Push Up" },
                    { 229, 0, 0, null, "Smith Machine Shrug" },
                    { 230, 0, 0, null, "Bicycle Crunch" },
                    { 231, 0, 0, null, "Ring Muscle Ups" },
                    { 232, 0, 0, null, "Reverse Crunches" },
                    { 233, 0, 0, null, "Dumbbell Split Squat" },
                    { 234, 0, 0, null, "Dumbbell Incline And Raise" },
                    { 235, 0, 0, null, "Side Lunge" },
                    { 236, 0, 0, null, "Sissy Squat" },
                    { 237, 0, 0, null, "One Arm Lat Pulldown" },
                    { 238, 0, 0, null, "Barbell Power Shrug" },
                    { 239, 0, 0, null, "Flutter Kicks" },
                    { 240, 0, 0, null, "Single Arm Landmine Press" },
                    { 241, 0, 0, null, "Single Leg Seated Calf Raise" },
                    { 242, 0, 0, null, "Donkey Calf Raise" },
                    { 243, 0, 0, null, "Machine Shrug" },
                    { 244, 0, 0, null, "Cable Leg Extension" },
                    { 245, 0, 0, null, "Decline Dumbbell Fly" },
                    { 246, 0, 0, null, "One Arm Pulldown" },
                    { 247, 0, 0, null, "Mountain Climbers" },
                    { 248, 0, 0, null, "Dumbbell Reverse Curl" },
                    { 249, 0, 0, null, "Dumbbell High Pull" },
                    { 250, 0, 0, null, "Hex Bar Shrug" },
                    { 251, 0, 0, null, "Cable Hammer Curl" },
                    { 252, 0, 0, null, "Clap Pull Up" },
                    { 253, 0, 0, null, "Single Leg Dumbbell Deadlift" },
                    { 254, 0, 0, null, "Dumbbell Face Pull" },
                    { 255, 0, 0, null, "Side Leg Lift" },
                    { 256, 0, 0, null, "Cable External Rotation" },
                    { 257, 0, 0, null, "Dumbbell Hang Clean" },
                    { 258, 0, 0, null, "Zercher Deadlift" },
                    { 259, 0, 0, null, "Cable Shrug" },
                    { 260, 0, 0, null, "Paused Squat" },
                    { 261, 0, 0, null, "Half Squat" },
                    { 262, 0, 0, null, "Side Crunch" },
                    { 263, 0, 0, null, "Jefferson Squat" },
                    { 264, 0, 0, null, "Bent Arm Barbell Pullover" },
                    { 265, 0, 0, null, "Dumbbell Clean and Press" },
                    { 266, 0, 0, null, "Close Grip Incline Bench Press" },
                    { 267, 0, 0, null, "Overhead Cable Curl" },
                    { 268, 0, 0, null, "Floor Hip Abduction" },
                    { 269, 0, 0, null, "Hang Snatch" },
                    { 270, 0, 0, null, "Standing Cable Crunch" },
                    { 271, 0, 0, null, "Behind The Back Barbell Shrug" },
                    { 272, 0, 0, null, "Archer Push Ups" },
                    { 273, 0, 0, null, "Squat Thrust" },
                    { 274, 0, 0, null, "Hip Extension" },
                    { 275, 0, 0, null, "Roman Chair Side Bend" },
                    { 276, 0, 0, null, "Glute Kickback" },
                    { 277, 0, 0, null, "Superman" },
                    { 278, 0, 0, null, "Meadows Row" },
                    { 279, 0, 0, null, "Spoto Press" },
                    { 280, 0, 0, null, "Dumbbell Thruster" },
                    { 281, 0, 0, null, "Scissor Kicks" },
                    { 282, 0, 0, null, "Dumbbell Walking Calf Raise" },
                    { 283, 0, 0, null, "Reverse Hyperextension" },
                    { 284, 0, 0, null, "Behind The Back Deadlift" },
                    { 285, 0, 0, null, "Floor Hip Extension" },
                    { 286, 0, 0, null, "Incline Cable Curl" },
                    { 287, 0, 0, null, "High Pulley Crunch" },
                    { 288, 0, 0, null, "Lying Cable Curl" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciceSet_UserExerciceUserId_UserExerciceExerciceId",
                table: "ExerciceSet",
                columns: new[] { "UserExerciceUserId", "UserExerciceExerciceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_UserExercices_ExerciceId",
                table: "UserExercices",
                column: "ExerciceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "ExerciceSet");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "UserExercices");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Exercices");
        }
    }
}
