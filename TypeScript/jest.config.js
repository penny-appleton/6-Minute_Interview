module.exports = {
	verbose: true,
	collectCoverage: false,
	preset: 'ts-jest',
	testEnvironment: 'node',
	moduleFileExtensions: ["ts", "js"],
	testMatch: ["**/*.test.ts"],
	collectCoverageFrom: [
		"**/*.ts",
		"!**/*.test.ts",
		"!**/node_modules/**",
		"!**/dist/**"
	]
};
