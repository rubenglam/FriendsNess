const { request, response } = require('express');
const bcryptjs = require('bcryptjs');

const Workout = require('../models/workout.model');

const getWorkouts = async (req = request, res = response) => {
	try {
		const workouts = Workout.find().populate('WorkoutExercice').populate('WorkoutExerciceSet');

		res.json({
			workouts,
		});
	} catch (error) {
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const createWorkout = async (req = request, res = response) => {
	const userId = req.id;
	const workout = new Workout({
		user: userId,
		...req.body,
	});

	try {
		const dbWorkout = await workout.save();

		res.json({
			dbWorkout,
		});
	} catch (error) {
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const updateWorkout = async (req = request, res = response) => {
  
};

const deleteWorkout = async (req = request, res = response) => {};

module.exports = { getWorkouts, createWorkout, updateWorkout, deleteWorkout };
