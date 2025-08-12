# Simple Calculator with pytest

A minimal example demonstrating how to use pytest with a simple calculator module.

## Setup

1. Create a virtual environment and activate it:

```bash
python -m venv venv
source venv/bin/activate  # On Windows: venv\Scripts\activate
```
Use `python -m venv venv` or `python3 -m venv venv`

2. Install dependencies:

```bash
pip install -r requirements.txt
```

## Running the tests

To run all tests:

```bash
pytest
```

To run tests with verbose output:

```bash
pytest -v
```

## Generating Test Reports

### JUnit XML Reports

```bash
pytest --junitxml=test-results.xml
```

## Learn More

For more information about this project, check out our [blog post](https://example.com/blog-post) (coming soon).
