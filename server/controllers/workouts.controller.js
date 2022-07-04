const { request, response } = require('express');

const WorkoutSchema = require('../models/workout.model');

const getWorkouts = async (req = request, res = response) => {
	const uid = req.uid;

	try {
		// Coger todos los workouts relacionados con el usuario que realizar la petición
		const workouts = WorkoutSchema.find({ user: uid }).populate('WorkoutExercice').populate('WorkoutExerciceSet');

		// Añade todos los workouts a la response
		res.json({
			workouts,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const getWorkout = async (req = request, res = response) => {
	const id = req.id;

	try {
		// Buscar el workout a partir del identificador
		const workout = await WorkoutSchema.findById(id);
		if (!workout) {
			return res.status(404).json({
				msg: 'Workout not found',
			});
		}

		// Añadir el workout a la response
		res.json({
			workout,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const createWorkout = async (req = request, res = response) => {
	const uid = req.uid;
	const workout = new WorkoutSchema({
		user: uid,
		...req.body,
	});

	try {
		// Guardar el workout en la base de datos
		const createdWorkout = await workout.save();

		// Añadir el workout creado a la response
		res.json({
			workout: createdWorkout,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const updateWorkout = async (req = request, res = response) => {
	const uid = req.uid;
	const id = req.params.id;

	try {
		// Comprobar si existe el workout
		const dbWorkout = WorkoutSchema.findById(id);
		if (!dbWorkout) {
			return res.status(401).json({
				msg: 'Workout not found',
			});
		}

		// Crear un workout con los datos a actualizar
		const workout = {
			...req.body,
			user: uid,
		};

		// Modificar los valores de la tabla para el workout seleccionado y devolver los nuevos datos
		const updatedWorkout = WorkoutSchema.findByIdAndUpdate(id, workout, { new: true });

		// Añadir el workout actualizado a la response
		res.json({
			workout: updatedWorkout,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const deleteWorkout = async (req = request, res = response) => {
	const id = req.params.id;

	try {
		// Si no existe el workout devuelve un error
		const workout = await WorkoutSchema.findById(id);
		if (!workout) {
			return res.status(404).json({
				msg: 'Workout not found',
			});
		}

		// Elimina el workout de la base de datos
		await WorkoutSchema.findByIdAndDelete(id);

		// Añade a la response que el workout fue eliminado correctamente
		res.json({
			msg: 'Workout deleted',
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

module.exports = { getWorkouts, getWorkout, createWorkout, updateWorkout, deleteWorkout };