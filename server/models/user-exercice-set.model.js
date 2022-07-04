const { Schema, model } = require('mongoose');

const UserExerciceSetSchema = Schema({
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
});

UserExerciceSetSchema.method('toJSON', function () {
	const { __v, ...object } = this.toObject();
	return object;
});

module.exports = model('UserExerciceSet', UserExerciceSetSchema);
