# Calculator - Cypress E2E Testing Demo

This project demonstrates end-to-end testing with Cypress using a modern calculator web application. It showcases comprehensive testing strategies including UI testing, user interactions, keyboard support, and edge case handling.

## 📋 Prerequisites

- Node.js (version 20 or higher)
- npm package manager

## 🛠️ Installation

1. **Clone or navigate to the project directory:**
   ```bash
   cd demo-cypress-tf
   ```

2. **Install dependencies:**
   ```bash
   npm install
   ```

## 🏃‍♂️ Running the Application

1. **Start the web server:**
   ```bash
   npm start
   ```
   The calculator will be available at `http://localhost:3000`

2. **In a new terminal, run Cypress tests:**

   **Interactive mode (recommended for development):**
   ```bash
   npm run cypress:open
   ```

   **Headless mode (for CI/CD):**
   ```bash
   npm test
   ```

   **Headless mode with browser visible:**
   ```bash
   npm run test:headed
   ```

## 📁 Project Structure

```
demo-cypress-tf/
├── src/
│   ├── index.html          # Main calculator HTML
│   ├── styles.css          # Modern CSS styling
│   └── calculator.js       # Calculator logic and keyboard support
├── cypress/
│   ├── e2e/
│   │   └── calculator.cy.js # Comprehensive test suite
│   └── support/
│       ├── commands.js      # Custom Cypress commands
│       └── e2e.js          # Support file configuration
├── cypress.config.js       # Cypress configuration
├── package.json           # Dependencies and scripts
└── README.md              # This file
```

Reports are generated in the `cypress/reports` directory.

## Learn More

For more information about this project, check out our [blog post](https://example.com/blog-post) (coming soon).
