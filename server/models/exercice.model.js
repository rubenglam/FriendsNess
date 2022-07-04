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
});

ExerciceSchema.method('toJSON', function () {
	const { __v, _id, ...object } = this.toObject();
	object.id = _id;
	return object;
});

module.exports = model('Exercice', ExerciceSchema);
