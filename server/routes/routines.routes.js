const { Router } = require('express');
const { check } = require('express-validator');

const { getRoutines, createRoutine, updateRoutine, deleteRoutine } = require('../controllers/routines.controller');
const { validateFields } = require('../middlewares/validate-fields');
const { validateJWT } = require('../middlewares/validate-jwt');

const router = Router();

// GET: "/api/routines"
router.get('', validateJWT, getRoutines);

// POST: "/api/routines"
router.post('', [validateFields, validateJWT], createRoutine);

// PUT: "/api/routines/{id}"
router.put('/:id', [validateFields, validateJWT], updateRoutine);

// DELETE: "/api/routines/{id}"
router.delete('/:id', validateJWT, deleteRoutine);

module.exports = router;
