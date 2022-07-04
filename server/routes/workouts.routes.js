const { Router } = require('express');
const { check } = require('express-validator');

const { getWorkouts, getWorkout, createWorkout, updateWorkout, deleteWorkout } = require('../controllers/workouts.controller');
const { validateFields } = require('../middlewares/validate-fields');
const { validateJWT } = require('../middlewares/validate-jwt');

const router = Router();

// GET: "/api/workouts/"
router.get('', validateJWT, getWorkouts);

// GET: "/api/workouts/{id}"
router.get('', validateJWT, getWorkout);

// POST: "/api/workouts"
router.post('', [validateFields, validateJWT], createWorkout);

// PUT: "/api/workouts/{id}"
router.put('/:id', [validateFields, validateJWT], updateWorkout);

// DELETE: "/api/workouts/{id}"
router.delete('/:id', validateJWT, deleteWorkout);

module.exports = router;
