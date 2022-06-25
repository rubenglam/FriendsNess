const { request, response } = require('express');
const { generateJWT } = require('../helpers/jwt');
const { googleVerify } = require('../helpers/google-verify');

const bcryptjs = require('bcryptjs');

const User = require('../models/user.model');

const login = async (req = request, res = response) => {
	const { email, password } = req.body;

	try {
		// Si no hay ningun usuario con ese email devuelve un error
		const dbUser = await User.findOne({ email });
		if (!dbUser) {
			return res.status(400).json({
				msg: 'Invalid credentials',
			});
		}

		// Validar si la contraseña es correcta
		const validPassword = bcryptjs.compareSync(password, dbUser.password);
		if (!validPassword) {
			return res.status(400).json({
				msg: 'Invalid credentials',
			});
		}

		// Generar un JWT
		const token = await generateJWT(dbUser.id);

		res.json({
			token,
		});
	} catch (error) {}
};

const googleSignIn = async (req = request, res = response) => {
	const token = req.body.token;

	try {
		const { name, email, picture } = await googleVerify(token);

		const dbUser = await User.findOne({ email });
		let user;
		if (!dbUser) {
			user = new User({
				name,
				email,
				img: picture,
				google: true,
			});
		} else {
			user = dbUser;
			user.google = true;
		}

		// Guardar en la base de datos
		await user.save();

		// Generar JWT
		const token = await generateJWT(dbUser.id);

		res.json({
			token,
		});
	} catch (error) {
		res.status(400).json({
			msg: 'Unknow error',
		});
	}
};

const register = async (req = request, res = response) => {
	try {
	} catch (error) {}
};

module.exports = { login, googleSignIn, register };