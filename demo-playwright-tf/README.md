# Playwright Test Demo

A demonstration of browser testing using Playwright Test framework.

## Description

This project demonstrates end-to-end testing of a ToDo web application using Playwright. It includes tests for various user interactions like adding, editing, completing, and filtering ToDo items.

## Requirements

- Node.js >= 18.0.0
- npm (please use npm as the package manager)

## Installation

1. Install dependencies:

```bash
npm install
```

2. Install Playwright browsers:

```bash
npx playwright install
```

## Running Tests

Run all tests in headless mode:

```bash
npx playwright test
```

Run tests with UI mode:

```bash
npx playwright test --ui
```

Run tests in a specific browser:

```bash
npx playwright test --project=chromium
npx playwright test --project=firefox
```

## Test Reports

HTML reports are automatically generated and can be viewed with:

```bash
npx playwright show-report
```

JUnit XML reports are also generated at `test-results.xml` for CI integration.

## Learn More

- [Playwright Documentation](https://playwright.dev/docs/intro)
- For more information about this project, check out our [blog post](https://example.com/blog-post) (coming soon).
