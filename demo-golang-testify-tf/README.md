# Golang Calculator with Testify Testing Framework

A comprehensive Go calculator demo showcasing the Testify testing framework with advanced features like test suites, assertions, and table-driven tests.

## Installation

```bash
go mod tidy
```

## Running the Demo

```bash
go run main.go
```

## Running Tests

```bash

go test -v ./test/...
```

## Generating Test Reports

### JUnit XML Report

```bash
# Install gotestsum (only needed once)
go install gotest.tools/gotestsum@latest

# Make sure ~/go/bin is in your PATH
export PATH=$PATH:~/go/bin

# Generate JUnit XML report
gotestsum --junitfile test-results.xml -- ./test/...
```

### JSON Report

```bash
go test -json ./test/... > test-results.json
```

## Learn More

For more information about Testify, visit:

- [Testify Documentation](https://github.com/stretchr/testify)
- [Go Testing Best Practices](https://golang.org/pkg/testing/)

For more information about this project, check out our [blog post](https://example.com/blog-post) (coming soon).
