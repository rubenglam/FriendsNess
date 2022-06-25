const { Schema, model } = require('mongoose');

const WorkoutSchema = Schema({
	name: {
		type: String,
		required: true,
	},
	description: { type: String },
	user: {
		type: Schema.Types.ObjectId,
		ref: 'User',
	},
	workoutExercices: [
		{
			type: Schema.Types.ObjectId,
			ref: 'WorkoutExercice',
		},
	],
});

WorkoutSchema.method('toJSON', function () {
	const { __v, _id, ...object } = this.toObject();
	object.id = _id;
	return object;
});

module.exports = model('Workout', WorkoutSchema);
