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
	userExerciceSets: [
		{
			type: Schema.Types.ObjectId,
			ref: 'UserExerciceSet',
		},
	],
});

UserExerciceSchema.method('toJSON', function () {
	const { __v, ...object } = this.toObject();
	return object;
});

module.exports = model('UserExercice', UserExerciceSchema);
