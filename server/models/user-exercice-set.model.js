const { Schema, model } = require('mongoose');

const ExerciceSetSchema = Schema({
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
	userExercice: {
		type: Schema.Types.ObjectId,
		ref: 'UserExercice',
		required: true,
	},
});

ExerciceSetSchema.method('toJSON', function () {
	const { __v, ...object } = this.toObject();
	return object;
});

module.exports = model('ExerciceSet', ExerciceSetSchema);
