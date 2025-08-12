/** @type {import('jest').Config} */
const config = {
  reporters: [
    'default',
    ['jest-junit', {outputDirectory: 'reports', outputName: 'test-results.xml'}],
  ],
};

module.exports = config;
