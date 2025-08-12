# Demo Rust Cargo Test Framework

A simple Rust demonstration project showing basic math operations and unit testing with JUnit XML report generation.

## Getting Started

### Prerequisites

- Rust and Cargo (install from [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install))
- cargo-junit for XML test reporting:
  ```bash
  cargo install cargo-junit
  ```

### Building the Project

```bash
cargo build
```

### Running the Application

```bash
cargo run
```

## Testing

### Running Tests

Run the standard Rust tests:

```bash
cargo test
```

### Generating JUnit XML Test Reports

To generate test results in JUnit XML format (useful for CI/CD systems):

```bash
cargo junit --name test-results.xml
```

This will create a `test-results.xml` file that can be consumed by CI/CD tools like Jenkins, TeamCity, or GitLab CI.

## Learn More

For more information about this project, check out our [blog post](https://example.com/blog-post) (coming soon).
