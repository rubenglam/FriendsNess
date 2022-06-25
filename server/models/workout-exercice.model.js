const { Schema, model } = require('mongoose');

const WorkoutExerciceSchema = Schema({
	name: {
		type: String,
		required: true,
	},
	exercice: {
		type: Schema.Types.ObjectId,
		ref: 'Exercice',
	},
	workout: {
		type: Schema.Types.ObjectId,
		ref: 'Workout',
	},
	workoutExerciceSets: [{ type: Schema.Types.ObjectId, ref: 'WorkoutExerciceSet' }],
});

WorkoutExerciceSchema.method('toJSON', function () {
	const { __v, ...object } = this.toObject();
	return object;
});

module.exports = model('WorkoutExercice', WorkoutExerciceSchema);
