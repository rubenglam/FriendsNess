const { OAuth2Client } = require('google-auth-library');

const client = new OAuth2Client(process.env.GOOGLE_ID);

const googleVerify = async (token) => {
	// Comprobar si el token es válido con google auth
	const ticket = await client.verifyIdToken({
		idToken: token,
		audience: process.env.GOOGLE_ID,
	});
	const payload = ticket.getPayload();
	const { name, email, picture } = payload;

	return { name, email, picture };
};

module.exports = {
	googleVerify,
};
