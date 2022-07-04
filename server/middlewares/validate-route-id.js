const { request, response } = require('express');
const { validationResult, check } = require('express-validator');
const { Types } = require('mongoose');

// Comprueba si hay errores en el formato del id
const validateRouteId = async (req = request, res = response, next) => {
	const { id } = req.params;

	//Comprobar si el id es válido
	const isValid = Types.ObjectId.isValid(id);
	if (!isValid) {
		return res.status(400).json({
			msg: 'Invalid id format',
		});
	}

	// Si no hay errores sigue hacia el siguiente ámbito
	next();
};

module.exports = { validateRouteId };
