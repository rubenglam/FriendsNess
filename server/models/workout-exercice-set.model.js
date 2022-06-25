const { Schema, model } = require('mongoose');

const WorkoutExerciceSetSchema = Schema({
	weight: {
		type: 'Number',
	},
	repetitions: {
		type: 'Number',
	},
	sets: {
		type: 'Number',
	},
	date: {
		type: 'Date',
	},
	completed: {
		type: 'Boolean',
	},
	workoutExercice: {
		type: Schema.Types.ObjectId,
		ref: 'WorkoutExercice',
	},
});

WorkoutExerciceSetSchema.method('toJSON', function () {
	const { __v, ...object } = this.toObject();
	return object;
});

module.exports = model('WorkoutExerciceSet', WorkoutExerciceSetSchema);
