const { request, response } = require('express');

const WorkoutExerciceSetSchema = require('../models/workout-exercice-set.model');

const getWorkoutExerciceSets = async (req = request, res = response) => {
	const id = req.params.id;

	try {
		// Coger todos los workout exercice sets de un workout exercice
		const workoutExerciceSets = WorkoutExerciceSetSchema.find({ workoutExercice: id });

		// Devuelve todos los workouts exercices set para un workout exercice
		return res.json({
			workoutExerciceSets,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const getWorkoutExerciceSet = async (req = request, res = response) => {
	const id = req.params.id;

	try {
		// Buscar el workout exercice set a partir del identificador
		const workoutExerciceSet = await WorkoutExerciceSetSchema.findById(id);
		if (!workoutExerciceSet) {
			return res.status(404).json({
				msg: 'Workout exercice set not found',
			});
		}

		// Devuelve el workout exercice set
		return res.json({
			workoutExerciceSet,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const createWorkoutExerciceSet = async (req = request, res = response) => {
	const workoutExerciceSet = new WorkoutExerciceSetSchema({
		...req.body,
	});

	try {
		// Guardar el workout exercice set en la base de datos
		const createdWorkoutExerciceSet = await workoutExerciceSet.save();

		// Devuelve el workout exercice set creado
		return res.json({
			workoutExercice: createdWorkoutExerciceSet,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const updateWorkoutExerciceSet = async (req = request, res = response) => {
	const id = req.params.id;

	try {
		// Comprobar si existe el workout exercice set
		const dbWorkoutExerciceSet = await WorkoutExerciceSetSchema.findById(id);
		if (!dbWorkoutExerciceSet) {
			return res.status(401).json({
				msg: 'Workout exercice set not found',
			});
		}

		// Crear un workout exercice con los datos a actualizar
		const workoutExerciceSet = {
			...req.body,
		};

		// Actualizar el workout exercice set en la base de datos y devolver los nuevos datos
		const updatedWorkoutExerciceSet = await WorkoutExerciceSetSchema.findByIdAndUpdate(id, workoutExerciceSet, { new: true });

		// Devuelve el workout exercice set actualizado
		return res.json({
			workoutExerciceSet: updatedWorkoutExerciceSet,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const deleteWorkoutExerciceSet = async (req = request, res = response) => {
	const id = req.params.id;

	try {
		// Si no existe el workout exercice set devuelve un error
		const workoutExerciceSet = await WorkoutExerciceSetSchema.findById(id);
		if (!workoutExerciceSet) {
			return res.status(404).json({
				msg: 'Workout exercice set not found',
			});
		}

		// Elimina el workout exercice set de la base de datos
		await WorkoutExerciceSetSchema.findByIdAndDelete(id);

		// Devuelve un message informando que el workout exercice set fue eliminado correctamente
		return res.json({
			msg: 'Workout exercice set deleted',
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

module.exports = { getWorkoutExerciceSets, getWorkoutExerciceSet, createWorkoutExerciceSet, updateWorkoutExerciceSet, deleteWorkoutExerciceSet };
