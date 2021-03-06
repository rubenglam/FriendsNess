const { Router } = require('express');
const { check } = require('express-validator');

const { getUserExercicesByUser, getUserExerciceById, createUserExercice, updateUserExercice, deleteUserExercice } = require('../controllers/user-exercices.controller');
const { validateFields } = require('../middlewares/validate-fields');
const { validateJWT } = require('../middlewares/validate-jwt');
const { route } = require('./exercices.routes');

const router = Router();

// GET: "/api/user-exercices"
router.get('', [validateJWT], getUserExercicesByUser);

// GET: "/api/user-exercices/{id}"
router.get('/:id', [validateJWT], getUserExerciceById);

// POST: "/api/user-exercices"
router.post('', [validateJWT, check('exerciceId', 'Exercice id is required').isMongoId(), validateFields], createUserExercice);

// PUT: "/api/user-exercices/{id}"
router.put('/:id', [validateJWT], updateUserExercice);

// DELETE: "/api/user-exercices/{id}"
router.delete('/:id', validateJWT, deleteUserExercice);

module.exports = router;
