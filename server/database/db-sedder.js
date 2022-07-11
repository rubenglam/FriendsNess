const fs = require('fs');

const Exercice = require('../models/exercice.model');

const seed = async () => {
	seedExcercices();
};

const seedExcercices = async () => {
	const exercicesCount = await Exercice.count();
	if (exercicesCount === 0) {
		const rawData = fs.readFileSync('exercices.json');
		const exercices = JSON.parse(rawData);
		exercices.forEach((exercice) => {
			const createdExercice = new Exercice(exercice);
			createdExercice.save();
		});
	}
};

module.exports = { seed };
