using FriendsNess.Core.Domain.Exercices;
using Microsoft.EntityFrameworkCore;

namespace FriendsNess.Data.Extensions;

public static class ModelBuilderExtensions
{
    private static readonly IEnumerable<Exercice> _exercices = new List<Exercice>()
    {
        new Exercice()
        {
            Id = 1,
            Name = "Bench Press",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Chest
        },
        new Exercice()
        {
            Id = 2,
            Name = "Squat",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 3,
            Name = "Deadlift",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.WholeBody
        },
        new Exercice()
        {
            Id = 4,
            Name = "Shoulder Press",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Shoulders
        },
        new Exercice()
        {
            Id = 5,
            Name = "Pull Ups",
            Category = ExerciceCategory.Bodyweight,
            BodyPart = BodyPart.Back
        },
        new Exercice()
        {
            Id = 6,
            Name = "Dumbbell Bench Press",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Chest
        },
        new Exercice()
        {
            Id = 7,
            Name = "Dumbbell Curl",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Biceps
        },
        new Exercice()
        {
            Id = 8,
            Name = "Bent Over Row",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Back
        },
        new Exercice()
        {
            Id = 9,
            Name = "Push Ups",
            Category = ExerciceCategory.Bodyweight,
            BodyPart = BodyPart.Chest
        },
        new Exercice()
        {
            Id = 10,
            Name = "Front Squat",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 11,
            Name = "Dumbbell Shoulder Press",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Shoulders
        },
        new Exercice()
        {
            Id = 12,
            Name = "Sled Leg Press",
            Category = ExerciceCategory.Machine,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 13,
            Name = "Incline Bench Press",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Chest
        },
        new Exercice()
        {
            Id = 14,
            Name = "Dips",
            Category = ExerciceCategory.Bodyweight,
            BodyPart = BodyPart.Triceps
        },
        new Exercice()
        {
            Id = 15,
            Name = "Power Clean",
            Category = ExerciceCategory.Olympic,
            BodyPart = BodyPart.WholeBody
        },
        new Exercice()
        {
            Id = 16,
            Name = "Lat Pulldown",
            Category = ExerciceCategory.Cable,
            BodyPart = BodyPart.Back
        },
        new Exercice()
        {
            Id = 17,
            Name = "Incline Dumbbell Bench Press",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Chest
        },
        new Exercice()
        {
            Id = 18,
            Name = "Hex Bar Deadlift",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.WholeBody
        },
        new Exercice()
        {
            Id = 19,
            Name = "Military Press",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Shoulders
        },
        new Exercice()
        {
            Id = 20,
            Name = "Chin Ups",
            Category = ExerciceCategory.Bodyweight,
            BodyPart = BodyPart.Back
        },
        new Exercice()
        {
            Id = 21,
            Name = "Sumo Deadlift",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.WholeBody
        },
        new Exercice()
        {
            Id = 22,
            Name = "Dumbbell Row",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Back
        },
        new Exercice()
        {
            Id = 23,
            Name = "Horizontal Leg Press",
            Category = ExerciceCategory.Machine,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 24,
            Name = "Hip Thrust",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 25,
            Name = "Dumbbell Lateral Raise",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Shoulders
        },
        new Exercice()
        {
            Id = 26,
            Name = "Romanian Deadlift",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.WholeBody
        },
        new Exercice()
        {
            Id = 27,
            Name = "Leg Extension",
            Category = ExerciceCategory.Machine,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 28,
            Name = "Chest Press",
            Category = ExerciceCategory.Machine,
            BodyPart = BodyPart.Chest
        },
        new Exercice()
        {
            Id = 29,
            Name = "Clean and Jerk",
            Category = ExerciceCategory.Olympic,
            BodyPart = BodyPart.WholeBody
        },
        new Exercice()
        {
            Id = 30,
            Name = "Tricep Pushdown",
            Category = ExerciceCategory.Cable,
            BodyPart = BodyPart.Triceps
        },
        new Exercice()
        {
            Id = 31,
            Name = "Snatch",
            Category = ExerciceCategory.Olympic,
            BodyPart = BodyPart.WholeBody
        },
        new Exercice()
        {
            Id = 32,
            Name = "Clean",
            Category = ExerciceCategory.Olympic,
            BodyPart = BodyPart.WholeBody
        },
        new Exercice()
        {
            Id = 33,
            Name = "Seated Cable Row",
            Category = ExerciceCategory.Cable,
            BodyPart = BodyPart.Back
        },
        new Exercice()
        {
            Id = 34,
            Name = "Hammer Curl",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Biceps
        },
        new Exercice()
        {
            Id = 35,
            Name = "Push Press",
            Category = ExerciceCategory.Olympic,
            BodyPart = BodyPart.Shoulders
        },
        new Exercice()
        {
            Id = 36,
            Name = "Barbell Shrug",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Back
        },
        new Exercice()
        {
            Id = 37,
            Name = "Decline Bench Press",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Chest
        },
        new Exercice()
        {
            Id = 38,
            Name = "Close Grip Bench Press",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Chest
        },
        new Exercice()
        {
            Id = 39,
            Name = "Clean and Press",
            Category = ExerciceCategory.Olympic,
            BodyPart = BodyPart.WholeBody
        },
        new Exercice()
        {
            Id = 40,
            Name = "Seated Leg Curl",
            Category = ExerciceCategory.Machine,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 41,
            Name = "Dumbbell Fly",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Chest
        },
        new Exercice()
        {
            Id = 42,
            Name = "T Bar Row",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Back
        },
        new Exercice()
        {
            Id = 43,
            Name = "Machine Calf Raise",
            Category = ExerciceCategory.Machine,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 44,
            Name = "Lying Leg Curl",
            Category = ExerciceCategory.Machine,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 45,
            Name = "Dumbbell Lunge",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 46,
            Name = "EZ Bar Curl",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Biceps
        },
        new Exercice()
        {
            Id = 47,
            Name = "Tricep Rope Pushdown",
            Category = ExerciceCategory.Cable,
            BodyPart = BodyPart.Triceps
        },
        new Exercice()
        {
            Id = 48,
            Name = "Dumbbell Shrug",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Back
        },
        new Exercice()
        {
            Id = 49,
            Name = "Lying Tricep Extension",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Triceps
        },
        new Exercice()
        {
            Id = 50,
            Name = "Seated Shoulder Press",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Shoulders
        },
        new Exercice()
        {
            Id = 51,
            Name = "Goblet Squat",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 52,
            Name = "Dumbbell Tricep Extension",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Triceps
        },
        new Exercice()
        {
            Id = 53,
            Name = "Rack Pull",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.WholeBody
        },
        new Exercice()
        {
            Id = 54,
            Name = "Preacher Curl",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Biceps
        },
        new Exercice()
        {
            Id = 55,
            Name = "Vertical Leg Press",
            Category = ExerciceCategory.Machine,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 56,
            Name = "Pendlay Row",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Back
        },
        new Exercice()
        {
            Id = 57,
            Name = "Dumbbell Bulgarian Split Squat",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 58,
            Name = "Machine Shoulder Press",
            Category = ExerciceCategory.Machine,
            BodyPart = BodyPart.Shoulders
        },
        new Exercice()
        {
            Id = 59,
            Name = "Machine Chest Fly",
            Category = ExerciceCategory.Machine,
            BodyPart = BodyPart.Chest
        },
        new Exercice()
        {
            Id = 60,
            Name = "Upright Row",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Shoulders
        },
        new Exercice()
        {
            Id = 61,
            Name = "Tricep Extension",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Triceps
        },
        new Exercice()
        {
            Id = 62,
            Name = "Box Squat",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 63,
            Name = "Dumbbell Front Raise",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Shoulders
        },
        new Exercice()
        {
            Id = 64,
            Name = "Hack Squat",
            Category = ExerciceCategory.Machine,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 65,
            Name = "Dumbbell Concentration Curl",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Biceps
        },
        new Exercice()
        {
            Id = 66,
            Name = "Cable Bicep Curl",
            Category = ExerciceCategory.Cable,
            BodyPart = BodyPart.Biceps
        },
        new Exercice()
        {
            Id = 67,
            Name = "Sit Ups",
            Category = ExerciceCategory.Bodyweight,
            BodyPart = BodyPart.Core
        },
        new Exercice()
        {
            Id = 68,
            Name = "Cable Lateral Raise",
            Category = ExerciceCategory.Cable,
            BodyPart = BodyPart.Shoulders
        },
        new Exercice()
        {
            Id = 69,
            Name = "Arnold Press",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Chest
        },
        new Exercice()
        {
            Id = 70,
            Name = "Bodyweight Squat",
            Category = ExerciceCategory.Bodyweight,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 71,
            Name = "Bulgarian Split Squat",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Legs
        },
        new Exercice()
        {
            Id = 72,
            Name = "Floor Press",
            Category = ExerciceCategory.Barbell,
            BodyPart = BodyPart.Chest
        },
        new Exercice()
        {
            Id = 73,
            Name = "Incline Dumbbell Fly",
            Category = ExerciceCategory.Dumbbell,
            BodyPart = BodyPart.Chest
        },
        new Exercice()
        {
            Id = 74,
            Name = "Good Morning"
        },
        new Exercice()
        {
            Id = 75,
            Name = "Cable Fly"
        },
        new Exercice()
        {
            Id = 76,
            Name = "Hang Clean"
        },
        new Exercice()
        {
            Id = 77,
            Name = "Seated Calf Raise"
        },
        new Exercice()
        {
            Id = 78,
            Name = "Muscle Ups"
        },
        new Exercice()
        {
            Id = 79,
            Name = "Stiff Leg Deadlift"
        },
        new Exercice()
        {
            Id = 80,
            Name = "Barbell Lunge"
        },
        new Exercice()
        {
            Id = 81,
            Name = "Zercher Squat"
        },
        new Exercice()
        {
            Id = 82,
            Name = "Dumbbell Romanian Deadlift"
        },
        new Exercice()
        {
            Id = 83,
            Name = "Overhead Squat"
        },
        new Exercice()
        {
            Id = 84,
            Name = "Dumbbell Pullover"
        },
        new Exercice()
        {
            Id = 85,
            Name = "Cable Crunch"
        },
        new Exercice()
        {
            Id = 86,
            Name = "Lying Dumbbell Tricep Extension"
        },
        new Exercice()
        {
            Id = 87,
            Name = "Smite Machine Bench Press"
        },
        new Exercice()
        {
            Id = 88,
            Name = "Face Pull"
        },
        new Exercice()
        {
            Id = 89,
            Name = "Hip Abduction"
        },
        new Exercice()
        {
            Id = 90,
            Name = "Incline Dumbbell Curl"
        },
        new Exercice()
        {
            Id = 91,
            Name = "Dumbbell Floor Press"
        },
        new Exercice()
        {
            Id = 92,
            Name = "Thruster"
        },
        new Exercice()
        {
            Id = 93,
            Name = "Dumbbell Reverse Fly"
        },
        new Exercice()
        {
            Id = 94,
            Name = "Machine Row"
        },
        new Exercice()
        {
            Id = 95,
            Name = "Push Jerk"
        },
        new Exercice()
        {
            Id = 96,
            Name = "Wrist Curl"
        },
        new Exercice()
        {
            Id = 97,
            Name = "Smith Machine Squat"
        },
        new Exercice()
        {
            Id = 98,
            Name = "Power Snatch"
        },
        new Exercice()
        {
            Id = 99,
            Name = "Hip Adduction"
        },
        new Exercice()
        {
            Id = 100,
            Name = "Dumbbell Tricep Kickback"
        },
        new Exercice()
        {
            Id = 101,
            Name = "Chest Supported Dumbbell Row"
        },
        new Exercice()
        {
            Id = 102,
            Name = "Decline Dumbbell Bench Press"
        },
        new Exercice()
        {
            Id = 103,
            Name = "Split Squat"
        },
        new Exercice()
        {
            Id = 104,
            Name = "Seated Dip Machine"
        },
        new Exercice()
        {
            Id = 105,
            Name = "Machine Seated Crunch"
        },
        new Exercice()
        {
            Id = 106,
            Name = "Cable Pull Through"
        },
        new Exercice()
        {
            Id = 107,
            Name = "Reverse Grip Bench Press"
        },
        new Exercice()
        {
            Id = 108,
            Name = "Crunches"
        },
        new Exercice()
        {
            Id = 109,
            Name = "Reverse Wrist Curl"
        },
        new Exercice()
        {
            Id = 110,
            Name = "Landmine Squat"
        },
        new Exercice()
        {
            Id = 111,
            Name = "Standing Leg Curl"
        },
        new Exercice()
        {
            Id = 112,
            Name = "Barbell Calf Raise"
        },
        new Exercice()
        {
            Id = 113,
            Name = "Reverse Barbell Curl"
        },
        new Exercice()
        {
            Id = 114,
            Name = "One Arm Cable Bicep Curl"
        },
        new Exercice()
        {
            Id = 115,
            Name = "Dumbbell Squat"
        },
        new Exercice()
        {
            Id = 116,
            Name = "Barbell Glute Bridge"
        },
        new Exercice()
        {
            Id = 117,
            Name = "Barbell Reverse Lunge"
        },
        new Exercice()
        {
            Id = 118,
            Name = "Deficit Deadlift"
        },
        new Exercice()
        {
            Id = 119,
            Name = "Dumbbell Calf Raise"
        },
        new Exercice()
        {
            Id = 120,
            Name = "Cable Crossover"
        },
        new Exercice()
        {
            Id = 121,
            Name = "Machine Tricep Extension"
        },
        new Exercice()
        {
            Id = 122,
            Name = "Paused Bench Press"
        },
        new Exercice()
        {
            Id = 123,
            Name = "One Arm Push Ups"
        },
        new Exercice()
        {
            Id = 124,
            Name = "Close Grip Lat Pulldown"
        },
        new Exercice()
        {
            Id = 125,
            Name = "Neck Curl"
        },
        new Exercice()
        {
            Id = 126,
            Name = "Dumbbell Deadlift"
        },
        new Exercice()
        {
            Id = 127,
            Name = "Strict Curl"
        },
        new Exercice()
        {
            Id = 128,
            Name = "Cable Reverse Fly"
        },
        new Exercice()
        {
            Id = 129,
            Name = "Cable Overhead Tricep Extension"
        },
        new Exercice()
        {
            Id = 130,
            Name = "Belt Squat"
        },
        new Exercice()
        {
            Id = 131,
            Name = "Dumbbell Upright Row"
        },
        new Exercice()
        {
            Id = 132,
            Name = "Barbell Hack Squat"
        },
        new Exercice()
        {
            Id = 133,
            Name = "Safety Bar Squat"
        },
        new Exercice()
        {
            Id = 134,
            Name = "Machine Bicep Curl"
        },
        new Exercice()
        {
            Id = 135,
            Name = "Machine Reverse Fly"
        },
        new Exercice()
        {
            Id = 136,
            Name = "Behind The Neck Press"
        },
        new Exercice()
        {
            Id = 137,
            Name = "Bench Pin Press"
        },
        new Exercice()
        {
            Id = 138,
            Name = "Dumbbell Wrist Curl"
        },
        new Exercice()
        {
            Id = 139,
            Name = "Barbell Front Raise"
        },
        new Exercice()
        {
            Id = 140,
            Name = "Clean High Pull"
        },
        new Exercice()
        {
            Id = 141,
            Name = "Single Leg Press"
        },
        new Exercice()
        {
            Id = 142,
            Name = "Close Grip Dumbbell Bench Press"
        },
        new Exercice()
        {
            Id = 143,
            Name = "Long Press"
        },
        new Exercice()
        {
            Id = 144,
            Name = "Reverse Grip Lat Pulldown"
        },
        new Exercice()
        {
            Id = 145,
            Name = "Bench Pull"
        },
        new Exercice()
        {
            Id = 146,
            Name = "Pause Squat"
        },
        new Exercice()
        {
            Id = 147,
            Name = "Handstand Push Ups"
        },
        new Exercice()
        {
            Id = 148,
            Name = "Diamond Push Ups"
        },
        new Exercice()
        {
            Id = 149,
            Name = "Single Leg Romanian Deadlift"
        },
        new Exercice()
        {
            Id = 150,
            Name = "Sled Press Calf Raise"
        },
        new Exercice()
        {
            Id = 151,
            Name = "Cable Woodchoppers"
        },
        new Exercice()
        {
            Id = 152,
            Name = "Clean Pull"
        },
        new Exercice()
        {
            Id = 153,
            Name = "Split Jerk"
        },
        new Exercice()
        {
            Id = 154,
            Name = "Straight Arm Pulldown"
        },
        new Exercice()
        {
            Id = 155,
            Name = "Sumo Squat"
        },
        new Exercice()
        {
            Id = 156,
            Name = "Incline Hammer Curl"
        },
        new Exercice()
        {
            Id = 157,
            Name = "Snatch Deadlift"
        },
        new Exercice()
        {
            Id = 158,
            Name = "Dumbbell Preacher Curl"
        },
        new Exercice()
        {
            Id = 159,
            Name = "Dumbbell Side Bend"
        },
        new Exercice()
        {
            Id = 160,
            Name = "Machine Back Extension"
        },
        new Exercice()
        {
            Id = 161,
            Name = "Burpees"
        },
        new Exercice()
        {
            Id = 162,
            Name = "Hang Power Clean"
        },
        new Exercice()
        {
            Id = 163,
            Name = "Yates Row"
        },
        new Exercice()
        {
            Id = 164,
            Name = "Jefferson Deadlift"
        },
        new Exercice()
        {
            Id = 165,
            Name = "Barbell Pullover"
        },
        new Exercice()
        {
            Id = 166,
            Name = "Dumbbell Snatch"
        },
        new Exercice()
        {
            Id = 167,
            Name = "Single Leg Deadlift"
        },
        new Exercice()
        {
            Id = 168,
            Name = "Pause Deadlift"
        },
        new Exercice()
        {
            Id = 169,
            Name = "Machine Lateral Raise"
        },
        new Exercice()
        {
            Id = 170,
            Name = "Landmine Press"
        },
        new Exercice()
        {
            Id = 171,
            Name = "Muscle Snatch"
        },
        new Exercice()
        {
            Id = 172,
            Name = "Wide Grip Bench Press"
        },
        new Exercice()
        {
            Id = 173,
            Name = "Seated Dumbbell Shoulder Press"
        },
        new Exercice()
        {
            Id = 174,
            Name = "Reverse Grip Tricep Pushdown"
        },
        new Exercice()
        {
            Id = 175,
            Name = "Dumbbell Bench Pull"
        },
        new Exercice()
        {
            Id = 176,
            Name = "Cable Kickback"
        },
        new Exercice()
        {
            Id = 177,
            Name = "Neck Extension"
        },
        new Exercice()
        {
            Id = 178,
            Name = "Z Press"
        },
        new Exercice()
        {
            Id = 179,
            Name = "Reverse Curl"
        },
        new Exercice()
        {
            Id = 180,
            Name = "Renegade Row"
        },
        new Exercice()
        {
            Id = 181,
            Name = "Shoulder Pin Press"
        },
        new Exercice()
        {
            Id = 182,
            Name = "Zottman Curl"
        },
        new Exercice()
        {
            Id = 183,
            Name = "Viking Press"
        },
        new Exercice()
        {
            Id = 184,
            Name = "Neutral Grip Pull Ups"
        },
        new Exercice()
        {
            Id = 185,
            Name = "Tate Press"
        },
        new Exercice()
        {
            Id = 186,
            Name = "Lunge"
        },
        new Exercice()
        {
            Id = 187,
            Name = "Snatch Pull"
        },
        new Exercice()
        {
            Id = 188,
            Name = "Spider Curl"
        },
        new Exercice()
        {
            Id = 189,
            Name = "Dumbbell Z Press"
        },
        new Exercice()
        {
            Id = 190,
            Name = "JM Press"
        },
        new Exercice()
        {
            Id = 191,
            Name = "Pin Squat"
        },
        new Exercice()
        {
            Id = 192,
            Name = "One Arm Pull Ups"
        },
        new Exercice()
        {
            Id = 193,
            Name = "Wall Ball"
        },
        new Exercice()
        {
            Id = 194,
            Name = "Glute Bridge"
        },
        new Exercice()
        {
            Id = 195,
            Name = "Back Extension"
        },
        new Exercice()
        {
            Id = 196,
            Name = "Pistol Squat"
        },
        new Exercice()
        {
            Id = 197,
            Name = "Hanging Leg Raise"
        },
        new Exercice()
        {
            Id = 198,
            Name = "Inverted Row"
        },
        new Exercice()
        {
            Id = 199,
            Name = "Russian Twist"
        },
        new Exercice()
        {
            Id = 200,
            Name = "Bent Over Dumbbell Row"
        },
        new Exercice()
        {
            Id = 201,
            Name = "Bodyweight Calf Raise"
        },
        new Exercice()
        {
            Id = 202,
            Name = "Lying Leg Raise"
        },
        new Exercice()
        {
            Id = 203,
            Name = "Seated Dumbbell Tricep Extension"
        },
        new Exercice()
        {
            Id = 204,
            Name = "Bench Dips"
        },
        new Exercice()
        {
            Id = 205,
            Name = "Ring Dips"
        },
        new Exercice()
        {
            Id = 206,
            Name = "Toes To Bar"
        },
        new Exercice()
        {
            Id = 207,
            Name = "Cheat Curl"
        },
        new Exercice()
        {
            Id = 208,
            Name = "Seated Dumbbell Curl"
        },
        new Exercice()
        {
            Id = 209,
            Name = "Dumbbell Front Squat"
        },
        new Exercice()
        {
            Id = 210,
            Name = "Walking Lung"
        },
        new Exercice()
        {
            Id = 211,
            Name = "Decline Push Ups"
        },
        new Exercice()
        {
            Id = 212,
            Name = "Ab Wheel Rollout"
        },
        new Exercice()
        {
            Id = 213,
            Name = "Reverse Lunge"
        },
        new Exercice()
        {
            Id = 214,
            Name = "Dumbbell Reverse Wrist Curl"
        },
        new Exercice()
        {
            Id = 215,
            Name = "Hanging Knee Raise"
        },
        new Exercice()
        {
            Id = 216,
            Name = "Glute Ham Raise"
        },
        new Exercice()
        {
            Id = 217,
            Name = "Nordic Hamstring Curl"
        },
        new Exercice()
        {
            Id = 218,
            Name = "Decline Crunch"
        },
        new Exercice()
        {
            Id = 219,
            Name = "Close Grip Push Up"
        },
        new Exercice()
        {
            Id = 220,
            Name = "Decline Sit Up"
        },
        new Exercice()
        {
            Id = 221,
            Name = "Jumping Jack"
        },
        new Exercice()
        {
            Id = 222,
            Name = "Squat Jumps"
        },
        new Exercice()
        {
            Id = 223,
            Name = "Dumbbell Push Press"
        },
        new Exercice()
        {
            Id = 224,
            Name = "Incline Push Up"
        },
        new Exercice()
        {
            Id = 225,
            Name = "Dumbbell External Rotation"
        },
        new Exercice()
        {
            Id = 226,
            Name = "One Arm Seated Cable Row"
        },
        new Exercice()
        {
            Id = 227,
            Name = "Cable Upright Row"
        },
        new Exercice()
        {
            Id = 228,
            Name = "Pike Push Up"
        },
        new Exercice()
        {
            Id = 229,
            Name = "Smith Machine Shrug"
        },
        new Exercice()
        {
            Id = 230,
            Name = "Bicycle Crunch"
        },
        new Exercice()
        {
            Id = 231,
            Name = "Ring Muscle Ups"
        },
        new Exercice()
        {
            Id = 232,
            Name = "Reverse Crunches"
        },
        new Exercice()
        {
            Id = 233,
            Name = "Dumbbell Split Squat"
        },
        new Exercice()
        {
            Id = 234,
            Name = "Dumbbell Incline And Raise"
        },
        new Exercice()
        {
            Id = 235,
            Name = "Side Lunge"
        },
        new Exercice()
        {
            Id = 236,
            Name = "Sissy Squat"
        },
        new Exercice()
        {
            Id = 237,
            Name = "One Arm Lat Pulldown"
        },
        new Exercice()
        {
            Id = 238,
            Name = "Barbell Power Shrug"
        },
        new Exercice()
        {
            Id = 239,
            Name = "Flutter Kicks"
        },
        new Exercice()
        {
            Id = 240,
            Name = "Single Arm Landmine Press"
        },
        new Exercice()
        {
            Id = 241,
            Name = "Single Leg Seated Calf Raise"
        },
        new Exercice()
        {
            Id = 242,
            Name = "Donkey Calf Raise"
        },
        new Exercice()
        {
            Id = 243,
            Name = "Machine Shrug"
        },
        new Exercice()
        {
            Id = 244,
            Name = "Cable Leg Extension"
        },
        new Exercice()
        {
            Id = 245,
            Name = "Decline Dumbbell Fly"
        },
        new Exercice()
        {
            Id = 246,
            Name = "One Arm Pulldown"
        },
        new Exercice()
        {
            Id = 247,
            Name = "Mountain Climbers"
        },
        new Exercice()
        {
            Id = 248,
            Name = "Dumbbell Reverse Curl"
        },
        new Exercice()
        {
            Id = 249,
            Name = "Dumbbell High Pull"
        },
        new Exercice()
        {
            Id = 250,
            Name = "Hex Bar Shrug"
        },
        new Exercice()
        {
            Id = 251,
            Name = "Cable Hammer Curl"
        },
        new Exercice()
        {
            Id = 252,
            Name = "Clap Pull Up"
        },
        new Exercice()
        {
            Id = 253,
            Name = "Single Leg Dumbbell Deadlift"
        },
        new Exercice()
        {
            Id = 254,
            Name = "Dumbbell Face Pull"
        },
        new Exercice()
        {
            Id = 255,
            Name = "Side Leg Lift"
        },
        new Exercice()
        {
            Id = 256,
            Name = "Cable External Rotation"
        },
        new Exercice()
        {
            Id = 257,
            Name = "Dumbbell Hang Clean"
        },
        new Exercice()
        {
            Id = 258,
            Name = "Zercher Deadlift"
        },
        new Exercice()
        {
            Id = 259,
            Name = "Cable Shrug"
        },
        new Exercice()
        {
            Id = 260,
            Name = "Paused Squat"
        },
        new Exercice()
        {
            Id = 261,
            Name = "Half Squat"
        },
        new Exercice()
        {
            Id = 262,
            Name = "Side Crunch"
        },
        new Exercice()
        {
            Id = 263,
            Name = "Jefferson Squat"
        },
        new Exercice()
        {
            Id = 264,
            Name = "Bent Arm Barbell Pullover"
        },
        new Exercice()
        {
            Id = 265,
            Name = "Dumbbell Clean and Press"
        },
        new Exercice()
        {
            Id = 266,
            Name = "Close Grip Incline Bench Press"
        },
        new Exercice()
        {
            Id = 267,
            Name = "Overhead Cable Curl"
        },
        new Exercice()
        {
            Id = 268,
            Name = "Floor Hip Abduction"
        },
        new Exercice()
        {
            Id = 269,
            Name = "Hang Snatch"
        },
        new Exercice()
        {
            Id = 270,
            Name = "Standing Cable Crunch"
        },
        new Exercice()
        {
            Id = 271,
            Name = "Behind The Back Barbell Shrug"
        },
        new Exercice()
        {
            Id = 272,
            Name = "Archer Push Ups"
        },
        new Exercice()
        {
            Id = 273,
            Name = "Squat Thrust"
        },
        new Exercice()
        {
            Id = 274,
            Name = "Hip Extension"
        },
        new Exercice()
        {
            Id = 275,
            Name = "Roman Chair Side Bend"
        },
        new Exercice()
        {
            Id = 276,
            Name = "Glute Kickback"
        },
        new Exercice()
        {
            Id = 277,
            Name = "Superman"
        },
        new Exercice()
        {
            Id = 278,
            Name = "Meadows Row"
        },
        new Exercice()
        {
            Id = 279,
            Name = "Spoto Press"
        },
        new Exercice()
        {
            Id = 280,
            Name = "Dumbbell Thruster"
        },
        new Exercice()
        {
            Id = 281,
            Name = "Scissor Kicks"
        },
        new Exercice()
        {
            Id = 282,
            Name = "Dumbbell Walking Calf Raise"
        },
        new Exercice()
        {
            Id = 283,
            Name = "Reverse Hyperextension"
        },
        new Exercice()
        {
            Id = 284,
            Name = "Behind The Back Deadlift"
        },
        new Exercice()
        {
            Id = 285,
            Name = "Floor Hip Extension"
        },
        new Exercice()
        {
            Id = 286,
            Name = "Incline Cable Curl"
        },
        new Exercice()
        {
            Id = 287,
            Name = "High Pulley Crunch"
        },
        new Exercice()
        {
            Id = 288,
            Name = "Lying Cable Curl"
        }
    };

    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exercice>().HasData(_exercices);
    }
}
