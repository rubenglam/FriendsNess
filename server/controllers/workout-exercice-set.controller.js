// const { request, response } = require('express');

// const WorkoutExerciceSetSchema = require('../models/workout-exercice-set.model');

// const getWorkoutExerciceSets = async (req = request, res = response) => {
// 	const id = req.params.id;

// 	try {
// 		// Coger todos los workout exercice sets de un workout exercice
// 		const workoutExercices = WorkoutExerciceSetSchema.find({ workout: id }).populate('WorkoutExerciceSet');

// 		// Devuelve todos los workouts
// 		return res.json({
// 			workoutExercices,
// 		});
// 	} catch (error) {
// 		console.log(error);
// 		return res.status(500).json({
// 			msg: 'Unknow error',
// 		});
// 	}
// };

// const getWorkoutExercice = async (req = request, res = response) => {
// 	const id = req.id;

// 	try {
// 		// Buscar el workout exercice a partir del identificador
// 		const workoutExercice = await WorkoutExerciceSchema.findById(id);
// 		if (!workoutExercice) {
// 			return res.status(404).json({
// 				msg: 'Workout exercice not found',
// 			});
// 		}

// 		// Devuelve el workout exercice
// 		return res.json({
// 			workoutExercice,
// 		});
// 	} catch (error) {
// 		console.log(error);
// 		return res.status(500).json({
// 			msg: 'Unknow error',
// 		});
// 	}
// };

// const createWorkoutExercice = async (req = request, res = response) => {
// 	const workoutExercice = new WorkoutExerciceSchema({
// 		...req.body,
// 	});

// 	try {
// 		// Guardar el workout exercice en la base de datos
// 		const createdWorkoutExercice = await workoutExercice.save();

// 		// Devuelve el workout exercice creado
// 		return res.json({
// 			workoutExercice: createdWorkoutExercice,
// 		});
// 	} catch (error) {
// 		console.log(error);
// 		return res.status(500).json({
// 			msg: 'Unknow error',
// 		});
// 	}
// };

// const updateWorkoutExercice = async (req = request, res = response) => {
// 	const id = req.params.id;

// 	try {
// 		// Comprobar si existe el workout exercice
// 		const dbWorkoutExercice = await WorkoutExerciceSchema.findById(id);
// 		if (!dbWorkoutExercice) {
// 			return res.status(401).json({
// 				msg: 'Workout exercice not found',
// 			});
// 		}

// 		// Crear un workout exercice con los datos a actualizar
// 		const workoutExercice = {
// 			...req.body,
// 		};

// 		// Actualizar el workout exercice en la base de datos y devolver los nuevos datos
// 		const updatedWorkoutExercice = await WorkoutExerciceSchema.findByIdAndUpdate(id, workoutExercice, { new: true });

// 		// Devuelve el workout exercice actualizado
// 		return res.json({
// 			workoutExercice: updatedWorkoutExercice,
// 		});
// 	} catch (error) {
// 		console.log(error);
// 		return res.status(500).json({
// 			msg: 'Unknow error',
// 		});
// 	}
// };

// const deleteWorkoutExercice = async (req = request, res = response) => {
// 	const id = req.params.id;

// 	try {
// 		// Si no existe el workout exercice devuelve un error
// 		const workoutExercice = await WorkoutExerciceSchema.findById(id);
// 		if (!workoutExercice) {
// 			return res.status(404).json({
// 				msg: 'Workout exercice not found',
// 			});
// 		}

// 		// Elimina el workout exercice de la base de datos
// 		await WorkoutExerciceSchema.findByIdAndDelete(id);

// 		// Devuelve un message informando que el workout exercice fue eliminado correctamente
// 		return res.json({
// 			msg: 'Workout exercice deleted',
// 		});
// 	} catch (error) {
// 		console.log(error);
// 		return res.status(500).json({
// 			msg: 'Unknow error',
// 		});
// 	}
// };

// module.exports = { getWorkoutExercices, getWorkoutExercice, createWorkoutExercice, updateWorkoutExercice, deleteWorkoutExercice };
