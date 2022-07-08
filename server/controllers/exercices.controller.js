const { request, response } = require('express');

const Exercice = require('../models/exercice.model');

const getExercices = async (req = request, res = response) => {
	try {
		// Buscar todos los ejercicios existentes
		const exercices = await Exercice.find();

		// Devolver los ejercicios
		return res.json({
			exercices,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const getExerciceById = async (req = request, res = response) => {
	const id = req.params.id;
	try {
		// Buscar el ejercicio a partir del identificador
		const exercice = await Exercice.findById(id);
		if (!exercice) {
			return res.status(404).json({
				msg: 'Exercice not found',
			});
		}

		// Devolver el ejercicio buscado
		return res.json({
			exercice,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const createExercice = async (req = request, res = response) => {
	// TODO: Implementar la funcionalidad de crear ejercicios
};

const updateExercice = async (req = request, res = response) => {
	// TODO: Implementar la funcionalidad de actualizar ejercicios
};

const deleteExercice = async (req = request, res = response) => {
	// TODO: Implementar la funcionalidad de eliminar ejercicios
};

module.exports = { getExercices, getExerciceById, createExercice, updateExercice, deleteExercice };
