const { Schema, model } = require('mongoose');

const RoutineSchema = Schema({
	name: {
		type: String,
		required: true,
	},
	user: {
		type: Schema.Types.ObjectId,
		ref: 'User',
	},
	workouts: [
		{
			type: Schema.Types.ObjectId,
			ref: 'Workout',
		},
	],
});

RoutineSchema.method('toJSON', function () {
	const { __v, _id, ...object } = this.toObject();
	object.id = _id;
	return object;
});

module.exports = model('Routine', RoutineSchema);
