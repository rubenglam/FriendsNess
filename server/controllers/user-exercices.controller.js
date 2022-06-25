const { request, response } = require('express');
const bcryptjs = require('bcryptjs');

const UserExercice = require('../models/user-exercice.model');
const UserExerciceSet = require('../models/user-exercice-set.model');

const getUserExercices = async (req = request, res = response) => {
	const userId = req.params.userId;

	try {
		const userExercices = UserExercice.find().populate('UserExerciceSet');

		res.json({
			userExercices,
		});
	} catch (error) {
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const getUserExerciceById = async (req = request, res = response) => {
	const id = req.params.id;

	try {
		const userExercice = UserExercice.findById(id).populate('UserExerciceSet');

		res.json({
			userExercice,
		});
	} catch (error) {
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const createUserExercice = async (req = request, res = response) => {
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

const updateUserExercice = async (req = request, res = response) => {
	const id = req.params.id;
	const uid = req.uid;

	try {
		const hospital = await Hospital.findById(id);

		if (!hospital) {
			return res.status(404).json({
				ok: true,
				msg: 'Hospital no encontrado por id',
			});
		}

		const cambiosHospital = {
			...req.body,
			usuario: uid,
		};

		const hospitalActualizado = await Hospital.findByIdAndUpdate(id, cambiosHospital, { new: true });

		res.json({
			ok: true,
			hospital: hospitalActualizado,
		});
	} catch (error) {
		console.log(error);

		res.status(500).json({
			ok: false,
			msg: 'Hable con el administrador',
		});
	}
};

const deleteUserExercice = async (req = request, res = response) => {};

module.exports = { getUserExercices, getUserExerciceById, createUserExercice, updateUserExercice, deleteUserExercice };
