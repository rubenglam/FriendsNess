const { Schema, model } = require('mongoose');

const UserExerciceSchema = Schema({
	user: {
		type: Schema.Types.ObjectId,
		ref: 'User',
		required: true,
	},
	exercice: {
		type: Schema.Types.ObjectId,
		ref: 'Exercice',
		required: true,
	},
	exerciceSets: [
		{
			type: Schema.Types.ObjectId,
			ref: 'ExerciceSet',
		},
	],
});

UserExerciceSchema.method('toJSON', function () {
	const { __v, ...object } = this.toObject();
	return object;
});

module.exports = model('UserExercice', UserExerciceSchema);
