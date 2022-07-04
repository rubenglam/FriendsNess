const { request, response } = require('express');

const UserExerciceSchema = require('../models/user-exercice.model');

const getUserExercicesByUser = async (req = request, res = response) => {
	const uid = req.uid;

	try {
		const userExercices = await UserExerciceSchema.find({ user: uid }).populate('userExerciceSet').populate('exercice');

		res.json({
			userExercices,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const getUserExerciceById = async (req = request, res = response) => {
	const id = req.params.id;

	try {
		const userExercice = UserExerciceSchema.findById(id).populate('userExerciceSet').populate('exercice');

		res.json({
			userExercice,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const createUserExercice = async (req = request, res = response) => {
	const uid = req.uid;
	const userExercice = new UserExerciceSchema({
		user: uid,
		...req.body,
	});

	try {
		const createdUserExercice = await userExercice.save();

		res.json({
			userExercice: createdUserExercice,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const updateUserExercice = async (req = request, res = response) => {
	const id = req.params.id;
	const uid = req.uid;

	try {
		// Comprobar que existe la relación userio con el ejercicio
		const dbUserExercice = await UserExerciceSchema.findById(id);
		if (!dbUserExercice) {
			return res.status(404).json({
				msg: 'User exercice not found',
			});
		}

		// Crear el model con los nuevos datos
		const userExercice = {
			...req.body,
			user: uid,
		};

		// Actualizar la tabla y devolver los nuevos datos
		const updatedUserExercice = await UserExerciceSchema.findByIdAndUpdate(id, userExercice, { new: true });

		// Añadir el modelo actualizado a la response
		res.json({
			userExercice: updatedUserExercice,
		});
	} catch (error) {
		console.log(error);
		res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const deleteUserExercice = async (req = request, res = response) => {
	const id = req.params.id;

	try {
		// Si no existe el usuario devuelve un error
		const userExists = await User.findById(id);
		if (!userExists) {
			return res.status(404).json({
				msg: 'User exercice not found',
			});
		}

		// Elimina el usuario
		await User.findByIdAndDelete(id);

		res.json({
			msg: 'User deleted',
		});
	} catch (error) {
		console.log(error);
		res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

module.exports = { getUserExercicesByUser, getUserExerciceById, createUserExercice, updateUserExercice, deleteUserExercice };
