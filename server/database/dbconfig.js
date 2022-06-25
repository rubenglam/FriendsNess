const mongoose = require('mongoose');

// Crear una connexión a la base de datos
const dbConnection = async () => {
	try {
		const connectionOptions = {
			useNewUrlParser: true,
			useUnifiedTopology: true,
		};
		console.log(process.env.DB_CONNECTION_STRING);
		await mongoose.connect(process.env.DB_CONNECTION_STRING, connectionOptions);
		console.log('Database Online');
	} catch (error) {
		console.log(error);
		throw new Error('Error on database inizialization');
	}
};

module.exports = { dbConnection };
