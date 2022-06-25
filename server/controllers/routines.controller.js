const { request, response } = require('express');
const bcryptjs = require('bcryptjs');

const Routine = require('../models/routine.model');

const getRoutines = async (req = request, res = response) => {
	try {
		const routines = Routine.find().populate('Workout').populate('WorkoutExercice').populate('WorkoutExerciceSet');

		res.json({
			routines,
		});
	} catch (error) {
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const createRoutine = async (req = request, res = response) => {};

const updateRoutine = async (req = request, res = response) => {};

const deleteRoutine = async (req = request, res = response) => {};

module.exports = { getRoutines, createRoutine, updateRoutine, deleteRoutine };
