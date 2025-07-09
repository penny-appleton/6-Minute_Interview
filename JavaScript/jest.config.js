module.exports = {
	testMatch: [
		'**/__tests__/**/*.+(js|jsx)',
		'**/?(*.)+(spec|test).+(js|jsx)'
	],
	collectCoverageFrom: [
		'**/*.js',
		'!**/node_modules/**',
		'!jest.config.js',
		'!**/*.spec.js',
		'!**/*.test.js'
	],
	coverageDirectory: 'coverage',
	testEnvironment: 'node'
};
