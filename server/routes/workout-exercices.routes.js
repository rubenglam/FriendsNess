const { Router } = require('express');
const { check } = require('express-validator');

const { getWorkoutExercices, getWorkoutExercice, createWorkoutExercice, updateWorkoutExercice, deleteWorkoutExercice } = require('../controllers/workout-exercice.controller');
const { validateFields } = require('../middlewares/validate-fields');
const { validateJWT } = require('../middlewares/validate-jwt');

const router = Router();

// GET: "/api/workout-exercices/{id}"
router.get('/:id', [validateJWT], getWorkoutExercices);

// GET: "/api/workout-exercices/{id}"
router.get('/:id', [validateJWT], getWorkoutExercice);

// POST: "/api/workout-exercices"
router.post('', [validateJWT], createWorkoutExercice);

// PUT: "/api/workout-exercices/{id}"
router.put('/:id', [validateJWT], updateWorkoutExercice);

// DELETE: "/api/workout-exercices/{id}"
router.delete('/:id', deleteWorkoutExercice);

module.exports = router;
