# Demo PestPHP Calculator

A simple PHP application demonstrating basic calculator functionality using PestPHP.

## Installation

First, clone the repository and install dependencies:

```bash
composer install
```

If you make changes to the class namespaces or directory structure, you'll need to update the autoloader:

```bash
composer dump-autoload
```

## Running Tests

Run the test suite with PestPHP:

```bash
./vendor/bin/pest
```

### JUnit Test Reports

To generate a JUnit XML report:

```bash
./vendor/bin/pest --log-junit=test-reports/test-results.xml
```

The JUnit reports will be stored in the `test-reports` directory with the filename `test-results.xml`.

## Configuration

The testing configuration is defined in:
- `phpunit.xml` - Contains the PHPUnit/Pest configuration
- `composer.json` - Contains the project dependencies and autoloading configuration
