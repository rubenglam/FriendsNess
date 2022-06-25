const { request, response } = require('express');
const jwt = require('jsonwebtoken');

const validateJWT = (req = request, res = response, next) => {
	// Coger el JWT de los header del request
	const token = req.headers('auth-token');
	// Devuelve un error si el token no existe
	if (!token) {
		return res.status(401).json({
			msg: 'Authorization failed',
		});
	}

	try {
		// Verificat el token
		jwt.verify(token, process.env.JWT_SECRET);
	} catch (error) {
		return res.status(401).json({
			msg: 'Invalid token',
		});
	}

	// Si no hay errores sigue hacia el siguiente ámbito
	next();
};

module.exports = {
	validateJWT,
};
