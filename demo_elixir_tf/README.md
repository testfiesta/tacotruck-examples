# DemoElixirTf

A simple Elixir application demonstrating basic calculator functionality and JUnit reporting that submits test results to a Testfiesta.

## Installation

### Dependencies

First, Install dependencies:

```bash
mix deps.get
```

## Running Tests

Run the test suite with:

```bash
mix test
```

### JUnit Test Reports

This project is configured to generate JUnit XML test reports, which are useful for CI/CD pipelines and reporting tools.

The test reports are stored in the `test-reports` directory with the filename `test-results.xml`.

To view the configuration for JUnit reporting, check:
- `config/test.exs` - Contains the JUnit formatter configuration
- `mix.exs` - Contains the JUnit formatter dependency

For more information, check out our detailed [blog post](https://example.com/blog-post) (coming soon).
