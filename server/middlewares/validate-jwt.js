const { request, response } = require('express');
const jwt = require('jsonwebtoken');

const validateJWT = (req = request, res = response, next) => {
	// Devuelve un error si el token no existe
	if (!req.headers.authorization) {
		return res.status(401).json({
			msg: 'Authorization failed',
		});
	}

	// Coger el JWT de los header del request. Se elimina la parte "Bearer " del string.
	// Formato: "Bearer {Token}"
	const token = req.headers.authorization.split(' ')[1];

	try {
		// Verificat el token
		const { uid } = jwt.verify(token, process.env.JWT_SECRET);
		req.uid = uid;
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
