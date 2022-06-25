const { request, response } = require('express');
const { validationResult } = require('express-validator');

// Comprueba si hay errores en el request
const validateFields = (req = Request, res = Response, next) => {
	const errors = validationResult(req);
	// Si hay errores devuelve un error response
	if (!errors.isEmpty()) {
		return res.status(400).json({
			errors: errors.mapped(),
		});
	}

	// Si no hay errores sigue hacia el siguiente ámbito
	next();
};

module.exports = { validateFields };
