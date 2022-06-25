const { Schema, model } = require('mongoose');

const ExerciceSchema = Schema({
	name: {
		type: String,
		required: true,
	},
	img: { type: String },
	category: {
		type: String,
	},
	bodyPart: {
		type: String,
	},
	user: {
		type: Schema.Types.ObjectId,
		ref: 'User',
	},
});

ExerciceSchema.method('toJSON', function () {
	const { __v, _id, ...object } = this.toObject();
	object.id = _id;
	return object;
});

module.exports = model('Exercice', ExerciceSchema);
