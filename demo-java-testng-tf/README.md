# Demo Java TestNG TF

This is a Java example project demonstrating the integration of TestNG testing framework with TacoTruck.

## Project Structure

```
demo-java-testng-tf/
├── src/
│   ├── main/
│   │   └── java/
│   │       └── com/
│   │           └── example/
│   │               └── Calculator.java
│   └── test/
│       └── java/
│           └── com/
│               └── example/
│                   └── CalculatorTest.java
├── pom.xml
├── .gitignore
└── README.md
```

## Prerequisites

- Java 11 or higher
- Maven 3.6 or higher

## Setup

1. **Clone the repository** (if not already done):
   ```bash
   git clone <repository-url>
   cd tacotruck-examples/demo-java-testng-tf
   ```

2. **Install dependencies**:
   ```bash
   mvn clean install
   ```

## Running Tests

### Run all tests
```bash
mvn test
```

The XML reports will be generated in `target/surefire-reports/` directory:
- `test-results.xml` - JUnit XML format report

## Learn More

For more information about this project, check out our [blog post](https://example.com/blog-post) (coming soon).
