require('dotenv').config();

const express = require('express');
const cors = require('cors');

const { dbConnection } = require('./database/dbconfig');
const { seed } = require('./database/db-sedder');

// Crear el servidor express
const app = express();

// Configurar CORS en el servidor
app.use(cors());

// Lectura y parseo del body
app.use(express.json());

// Crear la connexión con la base de datos
dbConnection();

// Seed de la base de datos
seed();

// Directorio público
app.use(express.static('public'));

// Rutas
app.use('/api/auth', require('./routes/auth.routes'));
app.use('/api/users', require('./routes/users.routes'));
app.use('/api/exercices', require('./routes/exercices.routes'));
app.use('/api/user-exercices', require('./routes/user-exercices.routes'));
app.use('/api/user-exercice-sets', require('./routes/user-exercice-sets.routes'));
app.use('/api/routines', require('./routes/routines.routes'));
app.use('/api/workouts', require('./routes/workouts.routes'));
app.use('/api/workout-exercices', require('./routes/workout-exercices.routes'));

// app.use('/api/search', require('/./routes/search.routes'));

// Encender el servidor
app.listen(process.env.PORT, () => {
	console.log('Servidor corriendo en el puerto', process.env.PORT);
});
