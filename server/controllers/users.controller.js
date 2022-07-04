const { request, response } = require('express');
const bcryptjs = require('bcryptjs');

const UserSchema = require('../models/user.model');

const getUsers = async (req = request, res = response) => {
	const queryFrom = Number(req.query.from) || 0;

	try {
		const [users, total] = await Promise.all(await UserSchema.find().skip(queryFrom).limit(10), await UserSchema.count());

		// Añadir los usuarios y la cantidad devueltos a la response
		res.json({
			users,
			total,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const getUser = async (req = request, res = response) => {
	const id = req.params.id;

	try {
		// Buscar el usuario a partir del identificador
		const user = await UserSchema.findById(id);
		if (!user) {
			return res.status(404).json({
				msg: 'User not found',
			});
		}

		// Añade el usuario a la response
		res.json({
			user,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const createUser = async (req = request, res = response) => {
	const { email, password } = req.body;

	try {
		// Comprueba si ya existe el usuario en la base de datos
		const userExists = await User.findOne({ email });
		if (userExists) {
			return res.status(400).json({
				msg: 'Email already exists',
			});
		}

		// Crear un usuario a partir del request
		const user = new User(req.body);

		// Encriptar contraseña
		const salt = bcryptjs.genSaltSync();
		user.password = bcryptjs.hashSync(password, salt);

		// Guardar el usuario
		await user.save();

		res.json(user);
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const updateUser = async (req = request, res = response) => {
	const id = req.params.id;

	try {
		// Comprobar si existe algun usuario con el id enviado
		const dbUser = await User.findById(id);
		if (!dbUser) {
			return res.status(404).json({
				msg: 'User not exists',
			});
		}

		// Separar los campos que no queremos actualizar nunca
		const { password, google, email, ...fields } = req.body;

		// Si existe alguno usuario con el nuevo email, devuelve un error de email ya utilizado
		if (dbUser.email != email) {
			const emailExists = await User.findOne({ email: req.body.email });
			if (emailExists) {
				return res.status(400).json({
					msg: 'Email already used',
				});
			}
		}

		// En este punto sabemos que nadie usa este email, podemos actualizarlo
		fields.email = email;

		// Actualizar usuario
		const updatedUser = await User.findByIdAndUpdate(id, fields, { new: true });

		// TODO: Validar token y comprobar si es el usuario correcto

		res.json({
			updatedUser,
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const deleteUser = async (req = request, res = response) => {
	const id = req.params.id;

	try {
		// Si no existe el usuario devuelve un error
		const userExists = await User.findById(id);
		if (!userExists) {
			return res.status(400).json({
				msg: 'User no exists',
			});
		}

		// Elimina el usuario
		await User.findByIdAndDelete(id);

		res.json({
			msg: 'User deleted',
		});
	} catch (error) {
		console.log(error);
		return res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

module.exports = { getUsers, getUser, createUser, updateUser, deleteUser };
