Cypress.Commands.add('performCalculation', (num1, operator, num2, expectedResult) => {
  cy.get('[data-cy="clear"]').click()
  
  num1.toString().split('').forEach(digit => {
    cy.get(`[data-cy="number-${digit}"]`).click()
  })
  
  cy.get(`[data-cy="${operator}"]`).click()
  
  num2.toString().split('').forEach(digit => {
    cy.get(`[data-cy="number-${digit}"]`).click()
  })
  
  cy.get('[data-cy="equals"]').click()
  
  cy.get('[data-cy="display"]').should('have.value', expectedResult.toString())
})

Cypress.Commands.add('enterNumber', (number) => {
  number.toString().split('').forEach(digit => {
    if (digit === '.') {
      cy.get('[data-cy="decimal"]').click()
    } else {
      cy.get(`[data-cy="number-${digit}"]`).click()
    }
  })
})
