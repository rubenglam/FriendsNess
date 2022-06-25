const fs = require('fs');

const Exercice = require('../models/exercice.model');

const seed = async () => {
	seedExcercices();
};

const seedExcercices = async () => {
	const exercicesCount = await Exercice.count();
	if (exercicesCount === 0) {
		const rawData = fs.readFileSync('exercices.json');
		const exercices = JSON.parse(rawData);
		exercices.forEach(exercice => {
			const createdExercice = new Exercice(exercice);
			createdExercice.save();
		});
	}
};

module.exports = { seed };

// {
//      110,
//     "name": "Landmine Squat"
// },

// {
//      111,
//     "name": "Standing Leg Curl"
// },

// {
//      112,
//     "name": "Barbell Calf Raise"
// },

// {
//      113,
//     "name": "Reverse Barbell Curl"
// },

// {
//      114,
//     "name": "One Arm Cable Bicep Curl"
// },

// {
//      115,
//     "name": "Dumbbell Squat"
// },

// {
//      116,
//     "name": "Barbell Glute Bridge"
// },

// {
//      117,
//     "name": "Barbell Reverse Lunge"
// },

// {
//      118,
//     "name": "Deficit Deadlift"
// },

// {
//      119,
//     "name": "Dumbbell Calf Raise"
// },

// {
//      120,
//     "name": "Cable Crossover"
// },

// {
//      121,
//     "name": "Machine Tricep Extension"
// },

// {
//      122,
//     "name": "Paused Bench Press"
// },

// {
//      123,
//     "name": "One Arm Push Ups"
// },

// {
//      124,
//     "name": "Close Grip Lat Pulldown"
// },

// {
//      125,
//     "name": "Neck Curl"
// },

// {
//      126,
//     "name": "Dumbbell Deadlift"
// },

// {
//      127,
//     "name": "Strict Curl"
// },

// {
//      128,
//     "name": "Cable Reverse Fly"
// },

// {
//      129,
//     "name": "Cable Overhead Tricep Extension"
// },

// {
//      130,
//     "name": "Belt Squat"
// },

// {
//      131,
//     "name": "Dumbbell Upright Row"
// },

// {
//      132,
//     "name": "Barbell Hack Squat"
// },

// {
//      133,
//     "name": "Safety Bar Squat"
// },

// {
//      134,
//     "name": "Machine Bicep Curl"
// },

// {
//      135,
//     "name": "Machine Reverse Fly"
// },

// {
//      136,
//     "name": "Behind The Neck Press"
// },

// {
//      137,
//     "name": "Bench Pin Press"
// },

// {
//      138,
//     "name": "Dumbbell Wrist Curl"
// },

// {
//      139,
//     "name": "Barbell Front Raise"
// },

// {
//      140,
//     "name": "Clean High Pull"
// },

// {
//      141,
//     "name": "Single Leg Press"
// },

// {
//      142,
//     "name": "Close Grip Dumbbell Bench Press"
// },

// {
//      143,
//     "name": "Long Press"
// },

// {
//      144,
//     "name": "Reverse Grip Lat Pulldown"
// },

// {
//      145,
//     "name": "Bench Pull"
// },

// {
//      146,
//     "name": "Pause Squat"
// },

// {
//      147,
//     "name": "Handstand Push Ups"
// },

// {
//      148,
//     "name": "Diamond Push Ups"
// },

// {
//      149,
//     "name": "Single Leg Romanian Deadlift"
// },

// {
//      150,
//     "name": "Sled Press Calf Raise"
// },

// {
//      151,
//     "name": "Cable Woodchoppers"
// },

// {
//      152,
//     "name": "Clean Pull"
// },

// {
//      153,
//     "name": "Split Jerk"
// },

// {
//      154,
//     "name": "Straight Arm Pulldown"
// },

// {
//      155,
//     "name": "Sumo Squat"
// },

// {
//      156,
//     "name": "Incline Hammer Curl"
// },

// {
//      157,
//     "name": "Snatch Deadlift"
// },

// {
//      158,
//     "name": "Dumbbell Preacher Curl"
// },

// {
//      159,
//     "name": "Dumbbell Side Bend"
// },

// {
//      160,
//     "name": "Machine Back Extension"
// },

// {
//      161,
//     "name": "Burpees"
// },

// {
//      162,
//     "name": "Hang Power Clean"
// },

// {
//      163,
//     "name": "Yates Row"
// },

// {
//      164,
//     "name": "Jefferson Deadlift"
// },

// {
//      165,
//     "name": "Barbell Pullover"
// },

// {
//      166,
//     "name": "Dumbbell Snatch"
// },

// {
//      167,
//     "name": "Single Leg Deadlift"
// },

// {
//      168,
//     "name": "Pause Deadlift"
// },

// {
//      169,
//     "name": "Machine Lateral Raise"
// },

// {
//      170,
//     "name": "Landmine Press"
// },

// {
//      171,
//     "name": "Muscle Snatch"
// },

// {
//      172,
//     "name": "Wide Grip Bench Press"
// },

// {
//      173,
//     "name": "Seated Dumbbell Shoulder Press"
// },

// {
//      174,
//     "name": "Reverse Grip Tricep Pushdown"
// },

// {
//      175,
//     "name": "Dumbbell Bench Pull"
// },

// {
//      176,
//     "name": "Cable Kickback"
// },

// {
//      177,
//     "name": "Neck Extension"
// },

// {
//      178,
//     "name": "Z Press"
// },

// {
//      179,
//     "name": "Reverse Curl"
// },

// {
//      180,
//     "name": "Renegade Row"
// },

// {
//      181,
//     "name": "Shoulder Pin Press"
// },

// {
//      182,
//     "name": "Zottman Curl"
// },

// {
//      183,
//     "name": "Viking Press"
// },

// {
//      184,
//     "name": "Neutral Grip Pull Ups"
// },

// {
//      185,
//     "name": "Tate Press"
// },

// {
//      186,
//     "name": "Lunge"
// },

// {
//      187,
//     "name": "Snatch Pull"
// },

// {
//      188,
//     "name": "Spider Curl"
// },

// {
//      189,
//     "name": "Dumbbell Z Press"
// },

// {
//      190,
//     "name": "JM Press"
// },

// {
//      191,
//     "name": "Pin Squat"
// },

// {
//      192,
//     "name": "One Arm Pull Ups"
// },

// {
//      193,
//     "name": "Wall Ball"
// },

// {
//      194,
//     "name": "Glute Bridge"
// },

// {
//      195,
//     "name": "Back Extension"
// },

// {
//      196,
//     "name": "Pistol Squat"
// },

// {
//      197,
//     "name": "Hanging Leg Raise"
// },

// {
//      198,
//     "name": "Inverted Row"
// },

// {
//      199,
//     "name": "Russian Twist"
// },

// {
//      200,
//     "name": "Bent Over Dumbbell Row"
// },

// {
//      201,
//     "name": "Bodyweight Calf Raise"
// },

// {
//      202,
//     "name": "Lying Leg Raise"
// },

// {
//      203,
//     "name": "Seated Dumbbell Tricep Extension"
// },

// {
//      204,
//     "name": "Bench Dips"
// },

// {
//      205,
//     "name": "Ring Dips"
// },

// {
//      206,
//     "name": "Toes To Bar"
// },

// {
//      207,
//     "name": "Cheat Curl"
// },

// {
//      208,
//     "name": "Seated Dumbbell Curl"
// },

// {
//      209,
//     "name": "Dumbbell Front Squat"
// },

// {
//      210,
//     "name": "Walking Lung"
// },

// {
//      211,
//     "name": "Decline Push Ups"
// },

// {
//      212,
//     "name": "Ab Wheel Rollout"
// },

// {
//      213,
//     "name": "Reverse Lunge"
// },

// {
//      214,
//     "name": "Dumbbell Reverse Wrist Curl"
// },

// {
//      215,
//     "name": "Hanging Knee Raise"
// },

// {
//      216,
//     "name": "Glute Ham Raise"
// },

// {
//      217,
//     "name": "Nordic Hamstring Curl"
// },

// {
//      218,
//     "name": "Decline Crunch"
// },

// {
//      219,
//     "name": "Close Grip Push Up"
// },

// {
//      220,
//     "name": "Decline Sit Up"
// },

// {
//      221,
//     "name": "Jumping Jack"
// },

// {
//      222,
//     "name": "Squat Jumps"
// },

// {
//      223,
//     "name": "Dumbbell Push Press"
// },

// {
//      224,
//     "name": "Incline Push Up"
// },

// {
//      225,
//     "name": "Dumbbell External Rotation"
// },

// {
//      226,
//     "name": "One Arm Seated Cable Row"
// },

// {
//      227,
//     "name": "Cable Upright Row"
// },

// {
//      228,
//     "name": "Pike Push Up"
// },

// {
//      229,
//     "name": "Smith Machine Shrug"
// },

// {
//      230,
//     "name": "Bicycle Crunch"
// },

// {
//      231,
//     "name": "Ring Muscle Ups"
// },

// {
//      232,
//     "name": "Reverse Crunches"
// },

// {
//      233,
//     "name": "Dumbbell Split Squat"
// },

// {
//      234,
//     "name": "Dumbbell Incline And Raise"
// },

// {
//      235,
//     "name": "Side Lunge"
// },

// {
//      236,
//     "name": "Sissy Squat"
// },

// {
//      237,
//     "name": "One Arm Lat Pulldown"
// },

// {
//      238,
//     "name": "Barbell Power Shrug"
// },

// {
//      239,
//     "name": "Flutter Kicks"
// },

// {
//      240,
//     "name": "Single Arm Landmine Press"
// },

// {
//      241,
//     "name": "Single Leg Seated Calf Raise"
// },

// {
//      242,
//     "name": "Donkey Calf Raise"
// },

// {
//      243,
//     "name": "Machine Shrug"
// },

// {
//      244,
//     "name": "Cable Leg Extension"
// },

// {
//      245,
//     "name": "Decline Dumbbell Fly"
// },

// {
//      246,
//     "name": "One Arm Pulldown"
// },

// {
//      247,
//     "name": "Mountain Climbers"
// },

// {
//      248,
//     "name": "Dumbbell Reverse Curl"
// },
