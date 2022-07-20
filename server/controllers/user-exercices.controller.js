const { request, response } = require('express');

const UserExerciceSchema = require('../models/user-exercice.model');

const getUserExercicesByUser = async (req = request, res = response) => {
	const uid = req.uid;

	try {
		const userExercices = await UserExerciceSchema.find({ user: uid }).populate('exercice').populate('user');

		// Devolver los user exercices
		return res.json({
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

		// Devolver el user exercice
		return res.json({
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
	const { exercice } = req.body;

	console.log(exercice);

	try {
		const exists = await UserExerciceSchema.findOne({ exercice: exerciceId, user: uid });
		console.log(exists);
		if (exists) {
			return res.status(404).json({
				msg: 'Duplicated user exercice',
			});
		}

		const userExercice = new UserExerciceSchema({
			user: uid,
			exercice: exerciceId,
		});

		const createdUserExercice = await userExercice.save();

		// Devolver el user exercice creado
		return res.json({
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

		// Devolver el user exercice actualizado
		return res.json({
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

		// Devolver un mensaje diciendo que el usuario ha sido eliminado correctamente
		return res.json({
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
