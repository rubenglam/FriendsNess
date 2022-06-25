const { request, response } = require('express');
const bcryptjs = require('bcryptjs');

const UserExerciceSet = require('../models/user-exercice-set.model');

const getUserExerciceSetById = async (req, res = response) => {
	const id = req.params.id;

	try {
		const userExerciceSet = await UserExerciceSet.findById(id).populate('userExercice');

		res.json({
			userExerciceSet,
		});
	} catch (error) {
		console.log(error);
		res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const createUserExerciceSet = async (req = request, res = response) => {
	// const userExerciceSet = new UserExerciceSet({
	// 	...req.body,
	// });

	// try {
	// 	const userExerciceSet = await userExerciceSet.save();

	// 	res.json({
	// 		userExerciceSet,
	// 	});
	// } catch (error) {
	// 	return res.status(500).json({
	// 		msg: 'Unknow error',
	// 	});
	// }

	// const uid = req.uid;
	// const userExerciceSet = new UserExerciceSet({
	// 		user: uid,
	// 		...req.body
	// });


	// try {
	// 		const createUserExerciceSet = await userExerciceSet.save();
			
	// 		res.json({
	// 				userExerciceSet: createUserExerciceSet
	// 		})

	// } catch (error) {
	// 		console.log(error);
	// 		res.status(500).json({
	// 				ok: false,
	// 				msg: 'Hable con el administrador'
	// 		})
	// }

};

const updateUserExerciceSet = async (req = request, res = response) => {
	const id = req.params.id;
	const uid = req.uid;

	try {
		const userExerciceSet = await UserExerciceSet.findById(id);

		if (!userExerciceSet) {
			return res.status(404).json({
				msg: 'User exercice set no found by id',
			});
		}

		const requestUserExerciceSet = {
			...req.body,
			usuario: uid,
		};

		const updatedUserExercice = await Hospital.findByIdAndUpdate(id, requestUserExerciceSet, { new: true });

		res.json({
			userExercice: updatedUserExercice,
		});
	} catch (error) {
		console.log(error);

		res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

const deleteUserExerciceSet = async (req, res = response) => {
	const id = req.params.id;

	try {
		const userExerciceSet = await UserExerciceSet.findById(id);

		if (!userExerciceSet) {
			return res.status(404).json({
				msg: 'User exercice set not found',
			});
		}

		await UserExerciceSet.findByIdAndDelete(id);

		res.json({
			msg: 'User exercice set deleted',
		});
	} catch (error) {
		console.log(error);

		res.status(500).json({
			msg: 'Unknow error',
		});
	}
};

module.exports = {
	getUserExerciceSetById,
	createUserExerciceSet,
	updateUserExerciceSet,
	deleteUserExerciceSet,
};
