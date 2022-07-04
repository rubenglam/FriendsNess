const { Router } = require('express');
const { check, buildCheckFunction } = require('express-validator');

const { getExercices, getExerciceById } = require('../controllers/exercices.controller');
const { validateFields } = require('../middlewares/validate-fields');
const { validateJWT } = require('../middlewares/validate-jwt');
const { validateRouteId } = require('../middlewares/validate-route-id');

const router = Router();

// GET: "/api/exercices/"
router.get('', validateJWT, getExercices);

// GET: "/api/exercices/{id}"
router.get('/:id', [validateJWT, validateRouteId], getExerciceById);

// // POST: "/api/users"
// router.post('', [check('name', 'Name is required').not().isEmpty(), check('password', 'Password is required').not().isEmpty(), check('email', 'Email is required').isEmail(), validateFields, validateJWT], createUser);

// // PUT: "/api/users/{id}"
// router.put('/:id', [check('name', 'Name is required').not().isEmpty(), check('password', 'Password is required').not().isEmpty(), check('role', 'Role is required').not(), validateFields, validateJWT], updateUser);

// // DELETE: "/api/users/{id}"
// router.delete('/:id', validateJWT, deleteUser);

module.exports = router;
