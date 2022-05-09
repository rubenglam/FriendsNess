using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FriendsNess.Server.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercices",
                columns: new[] { "Id", "Category", "ExercicedBodyParts", "Image", "Name" },
                values: new object[,]
                {
                    { 1, 0, 2, null, "Bench Press" },
                    { 2, 0, 0, null, "Squat" },
                    { 3, 0, 0, null, "Deadlift" },
                    { 4, 0, 0, null, "Shoulder Press" },
                    { 5, 0, 0, null, "Pull Ups" },
                    { 6, 0, 0, null, "Dumbbell Bench Press" },
                    { 7, 0, 0, null, "Bumbbell Curl" },
                    { 8, 0, 0, null, "Bent Over Row" },
                    { 9, 0, 0, null, "Push Ups" },
                    { 10, 0, 0, null, "Front Squat" },
                    { 11, 0, 0, null, "Dumbbell Shoulder Press" },
                    { 12, 0, 0, null, "Sled Leg Press" },
                    { 13, 0, 0, null, "Incline Bench Press" },
                    { 14, 0, 0, null, "Dips" },
                    { 15, 0, 0, null, "Power Clean" },
                    { 16, 0, 0, null, "Lat Pulldown" },
                    { 17, 0, 0, null, "Incline Dumbbell Bench Press" },
                    { 18, 0, 0, null, "Hex Bar Deadlift" },
                    { 19, 0, 0, null, "Military Press" },
                    { 20, 0, 0, null, "Chin Ups" },
                    { 21, 0, 0, null, "Sumo Deadlift" },
                    { 22, 0, 0, null, "Dumbbell Row" },
                    { 23, 0, 0, null, "Horizontal Leg Press" },
                    { 24, 0, 0, null, "Hip Thrust" },
                    { 25, 0, 0, null, "Dumbbell Lateral Raise" },
                    { 26, 0, 0, null, "Romanian Deadlift" },
                    { 27, 0, 0, null, "Leg Extension" },
                    { 28, 0, 0, null, "Chest Press" },
                    { 29, 0, 0, null, "Clean and Jerk" },
                    { 30, 0, 0, null, "Tricep Pushdown" },
                    { 31, 0, 0, null, "Snatch" },
                    { 32, 0, 0, null, "Clean" },
                    { 33, 0, 0, null, "Seated Cable Row" },
                    { 34, 0, 0, null, "Hammer Curl" },
                    { 35, 0, 0, null, "Push Press" },
                    { 36, 0, 0, null, "Barbell Shrug" },
                    { 37, 0, 0, null, "Decline Bench Press" },
                    { 38, 0, 0, null, "Close Grip Bench Press" },
                    { 39, 0, 0, null, "Clean and Press" },
                    { 40, 0, 0, null, "Seated Leg Curl" },
                    { 41, 0, 0, null, "Dumbbell Fly" },
                    { 42, 0, 0, null, "T Bar Row" },
                    { 43, 0, 0, null, "Machine Calf Raise" },
                    { 44, 0, 0, null, "Lying Leg Curl" },
                    { 45, 0, 0, null, "Dumbbell Lunge" },
                    { 46, 0, 0, null, "EZ Bar Curl" },
                    { 47, 0, 0, null, "Tricep Rope Pushdown" },
                    { 48, 0, 0, null, "Dumbbell Shrug" },
                    { 49, 0, 0, null, "Lying Tricep Extension" },
                    { 50, 0, 0, null, "Seated Shoulder Press" },
                    { 51, 0, 0, null, "Goblet Squat" },
                    { 52, 0, 0, null, "Dumbbell Tricep Extension" },
                    { 53, 0, 0, null, "Rack Pull" },
                    { 54, 0, 0, null, "Preacher Curl" },
                    { 55, 0, 0, null, "Vertical Leg Press" },
                    { 56, 0, 0, null, "Pendlay Row" },
                    { 57, 0, 0, null, "Dumbbell Bulgarian Split Squat" },
                    { 58, 0, 0, null, "Machine Shoulder Press" },
                    { 59, 0, 0, null, "Machine Chest Fly" },
                    { 60, 0, 0, null, "Upright Row" },
                    { 61, 0, 0, null, "Tricep Extension" },
                    { 62, 0, 0, null, "Box Squat" },
                    { 63, 0, 0, null, "Dumbbell Front Raise" },
                    { 64, 0, 0, null, "Hack Squat" },
                    { 65, 0, 0, null, "Dumbbell Concentration Curl" },
                    { 66, 0, 0, null, "Cable Bicep Curl" },
                    { 67, 0, 0, null, "Sit Ups" },
                    { 68, 0, 0, null, "Cable Lateral Raise" },
                    { 69, 0, 0, null, "Arnold Press" },
                    { 70, 0, 0, null, "Bodyweight Squat" },
                    { 71, 0, 0, null, "Bulgarian Split Squat" },
                    { 72, 0, 0, null, "Floor Press" },
                    { 73, 0, 0, null, "Incline Dumbbell Fly" },
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
                    { 99, 0, 0, null, "Hip Adduction" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 99);
        }
    }
}
