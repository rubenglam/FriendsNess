const { Router } = require('express');
const { check } = require('express-validator');

const { getExercices } = require('../controllers/exercices.controller');
const { validateFields } = require('../middlewares/validate-fields');
const { validateJWT } = require('../middlewares/validate-jwt');

const router = Router();

// GET: "/api/routines/"
//router.get('', validateJWT, getExercices);

// // POST: "/api/users"
// router.post('', [check('name', 'Name is required').not().isEmpty(), check('password', 'Password is required').not().isEmpty(), check('email', 'Email is required').isEmail(), validateFields, validateJWT], createUser);

// // PUT: "/api/users/{id}"
// router.put('/:id', [check('name', 'Name is required').not().isEmpty(), check('password', 'Password is required').not().isEmpty(), check('role', 'Role is required').not(), validateFields, validateJWT], updateUser);

// // DELETE: "/api/users/{id}"
// router.delete('/:id', validateJWT, deleteUser);

module.exports = router;
