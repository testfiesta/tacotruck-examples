# Demo .NET Calculator with MSTest Testing

## Overview

This repository demonstrates a simple calculator service implementation in .NET 8 with unit tests using the MSTest testing framework.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- IDE of your choice (Visual Studio, VS Code with C# extension, JetBrains Rider, etc.)

## Getting Started

### Build the Solution

```bash
dotnet build
```

### Run the Tests

```bash
dotnet test
```

### Generate JUnit Test Results

To generate JUnit-compatible XML test results, use the following command:

```bash
dotnet test --logger:"junit;LogFilePath=../test-results.xml"
```

This will create a test-results.xml file that can be consumed by CI/CD systems like Jenkins, Azure DevOps, or other tools that support the JUnit format.

## Learn More

For more information about this project, check out our [blog post](https://example.com/blog-post) (coming soon).
