const { request, response } = require('express');

const User = require('../models/user.model');
const Exercice = require('../models/exercice.model');
const Workout = require('../models/workout.model');

const getSearch = async (req = request, res = response) => {
	const paramName = req.params.name;

	// Crear una expresión para permitir una busqueda más compleja
	const regex = new RegExp(paramName, 'i');

	try {
		// Buscar los objetos que coinciden con la condición
		const [users, exercices, workouts] = await Promise.all(User.find({ name: regex }), Exercice.find({ name: regex }), Workout.find({ name: regex }));

		return res.json({
			users,
			exercices,
			workouts,
		});
	} catch (error) {
		return res.status(400).json({
			msg: 'Unknow error',
		});
	}
};

module.exports = { getSearch };
