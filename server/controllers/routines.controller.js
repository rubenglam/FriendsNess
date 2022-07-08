const { request, response } = require('express');

const RoutineSchema = require('../models/routine.model');

const getRoutines = async (req = request, res = response) => {
	const uid = req.uid;

	try {
		// Coger todas las routines relacionadas con el usuario que ha hecho la petición
		const routines = RoutineSchema.find({ user: uid }).populate('Workout').populate('WorkoutExercice').populate('WorkoutExerciceSet');

		// Devolver las routines
		return res.json({
			routines,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const createRoutine = async (req = request, res = response) => {
	const uid = req.uid;
	const routine = new RoutineSchema({
		user: uid,
		...req.body,
	});

	try {
		// Guardar los datos en la tabla
		const createdRoutine = await routine.save();

		// Devolver la routine creada
		return res.json({
			routine: createdRoutine,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const updateRoutine = async (req = request, res = response) => {
	const id = req.params.id;
	const uid = req.uid;

	try {
		// Comprobar si existe la rutina
		const dbRoutine = RoutineSchema.findById(id);
		if (!dbRoutine) {
			return res.status(401).json({
				msg: 'Routine not found',
			});
		}

		// Crear un nuevo modelo de rutina con los nuevos datos
		const routine = {
			...req.body,
			user: uid,
		};

		// Modificar los valores de la tabla para la rutina seleccionada y devolver los nuevos datos
		const updatedRoutine = RoutineSchema.findByIdAndUpdate(id, routine, { new: true });

		// Devolver la routine actualizada
		return res.json({
			routine: updatedRoutine,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const deleteRoutine = async (req = request, res = response) => {
	const id = req.params.id;

	try {
		// Si no existe la rutina devuelve un error
		const routine = await RoutineSchema.findById(id);
		if (!routine) {
			return res.status(404).json({
				msg: 'Routine not found',
			});
		}

		// Elimina la rutina de la base de datos
		await RoutineSchema.findByIdAndDelete(id);

		// Devolver un mensaje que la routine se ha eliminado correctamente
		return res.json({
			msg: 'Routine deleted',
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({ msg: 'Unknow error' });
	}
};

module.exports = { getRoutines, createRoutine, updateRoutine, deleteRoutine };
