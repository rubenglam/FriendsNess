const { Router } = require('express');
const { check } = require('express-validator');

const { getUserExerciceSetById, createUserExerciceSet, updateUserExerciceSet, deleteUserExerciceSet } = require('../controllers/user-exercice-sets.controller');
const { validateFields } = require('../middlewares/validate-fields');
const { validateJWT } = require('../middlewares/validate-jwt');
const { validateRouteId } = require('../middlewares/validate-route-id');

const router = Router();

// GET: "/api/user-exercice-sets/{id}"
router.get('/:id', [validateJWT, validateRouteId], getUserExerciceSetById);

// POST: "/api/user-exercice-sets"
router.post('', [validateJWT, validateFields], createUserExerciceSet);

// PUT "/api/user-exercice-sets/{id}"
router.put('/:id', [validateJWT, validateRouteId, validateFields], updateUserExerciceSet);

// DELETE: "/api/user-exercice-sets/{id}"
router.delete('/:id', [validateJWT, validateRouteId], deleteUserExerciceSet);

module.exports = router;
