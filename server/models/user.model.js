const { Schema, model } = require('mongoose');

const UserSchema = Schema({
	name: {
		type: String,
		required: true,
	},
	email: { type: String, required: true, unique: true },
	password: { type: String, required: true },
	img: { type: String },
	role: { type: String, required: true, default: 'USER_ROLE' },
	google: { type: Boolean, default: false },
	userExercices: [
		{
			type: Schema.Types.ObjectId,
			ref: 'UserExercice',
		},
	],
	workoutExercices: [
		{
			type: Schema.Types.ObjectId,
			ref: 'WorkoutExercice',
		},
	],
	routines: [
		{
			type: Schema.Types.ObjectId,
			ref: 'Routine',
		},
	],
});

UserSchema.method('toJSON', function () {
	const { __v, _id, password, ...object } = this.toObject();
	object.id = _id;
	return object;
});

module.exports = model('User', UserSchema);
