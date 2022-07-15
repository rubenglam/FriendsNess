const { request, response } = require('express');

const { generateJWT } = require('../helpers/jwt');
const { googleVerify } = require('../helpers/google-verify');

const bcryptjs = require('bcryptjs');

const UserSchema = require('../models/user.model');

const login = async (req = request, res = response) => {
	const { username, password } = req.body;
	console.log(req.body);
	try {
		// Si no hay ningun usuario con ese email devuelve un error
		const dbUser = await UserSchema.findOne({ username });
		if (dbUser === null) {
			return res.status(400).json({
				msg: 'Invalid credentials',
			});
		}

		// Validar si la contraseña es correcta
		const validPassword = bcryptjs.compareSync(password, dbUser.password);
		console.log(validPassword);
		if (!validPassword) {
			return res.status(400).json({
				msg: 'Invalid credentials',
			});
		}

		// Generar un JWT
		const token = await generateJWT(dbUser.id);

		// Devolver el token
		return res.json({
			user: dbUser,
			token,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const googleSignIn = async (req = request, res = response) => {
	// TODO: No acabo. Usar plataforma de GOOGLE
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

		// Devolver el token generado
		return res.json({
			token,
		});
	} catch (error) {
		console.log(error);
		return res.status(400).json({
			msg: 'Unknow error',
		});
	}
};

const register = async (req = request, res = response) => {
	const { username, email, password } = req.body;

	try {
		// Buscar usuarios con el mismo username para devolver un error
		const dbUser = await UserSchema.findOne({ username, email });
		if (dbUser !== null) {
			return res.status(400).json({
				msg: 'Duplicated username',
			});
		}

		// Crear un usuario con la información
		const user = new UserSchema({
			username,
			email,
			password,
		});

		// Encriptar contraseña
		const salt = bcryptjs.genSaltSync();
		user.password = bcryptjs.hashSync(password, salt);

		// Guardar en la base de datos el nuevo usuario
		const createdUser = await user.save();

		// Generar un token para el nuevo usuario
		const token = await generateJWT(createdUser.id);

		// Devolver el usuario creado y un token
		return res.json({
			user: createdUser,
			token,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const renewToken = async (req = request, res = response) => {
	const uid = req.uid;

	try {
		// Generar un nuevo token
		const token = await generateJWT(uid);

		// Comprobar la existencia del usuario
		const user = await UserSchema.findById(uid);
		if (!user) {
			return res.status(401).json({
				msg: 'User not exists',
			});
		}

		// Devolver el token renovado y el usuario
		return res.json({
			token,
			user,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

module.exports = { login, googleSignIn, register, renewToken };
