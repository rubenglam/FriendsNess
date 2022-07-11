const { Router } = require('express');
const { check } = require('express-validator');

const { login, register, renewToken } = require('../controllers/auth.controller');
const { validateFields } = require('../middlewares/validate-fields');
const { validateJWT } = require('../middlewares/validate-jwt');

const router = Router();

// POST: "/api/auth/login"
router.post('/login', validateFields, login);

// POST: "/api/login/login-google"
// router.post('/login-google', validateFields);

// POST: "/api/auth/register"
router.post('/register', validateFields, register);

// GET: "/api/auth/renewToken"
router.get('/renewToken', validateJWT, renewToken);

module.exports = router;
