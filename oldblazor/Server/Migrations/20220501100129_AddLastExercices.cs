using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FriendsNess.Server.Migrations
{
    public partial class AddLastExercices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercices",
                columns: new[] { "Id", "Category", "ExercicedBodyParts", "Image", "Name" },
                values: new object[,]
                {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Exercices",
                keyColumn: "Id",
                keyValue: 288);
        }
    }
}
