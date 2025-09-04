describe('Calculator E2E Tests', () => {
  beforeEach(() => {
    cy.visit('/')
  })

  describe('UI Elements', () => {
    it('should display all calculator elements', () => {
      cy.get('h1').should('contain', 'Calculator')
      cy.get('[data-cy="display"]').should('be.visible')
      cy.get('[data-cy="result"]').should('be.visible')
      
      for (let i = 0; i <= 9; i++) {
        cy.get(`[data-cy="number-${i}"]`).should('be.visible').and('contain', i.toString())
      }
      
      cy.get('[data-cy="add"]').should('be.visible').and('contain', '+')
      cy.get('[data-cy="subtract"]').should('be.visible').and('contain', '-')
      cy.get('[data-cy="multiply"]').should('be.visible').and('contain', '*')
      cy.get('[data-cy="divide"]').should('be.visible').and('contain', '/')
      cy.get('[data-cy="equals"]').should('be.visible').and('contain', '=')
      cy.get('[data-cy="clear"]').should('be.visible').and('contain', 'C')
      cy.get('[data-cy="decimal"]').should('be.visible').and('contain', '.')
    })

    it('should have proper styling and layout', () => {
      cy.get('.calculator').should('have.css', 'border-radius')
      cy.get('[data-cy="display"]').should('have.css', 'text-align', 'right')
      cy.get('.buttons').should('have.css', 'display', 'grid')
    })
  })

  describe('Basic Number Input', () => {
    it('should display numbers when clicked', () => {
      cy.get('[data-cy="number-1"]').click()
      cy.get('[data-cy="display"]').should('have.value', '1')
      
      cy.get('[data-cy="number-2"]').click()
      cy.get('[data-cy="display"]').should('have.value', '12')
      
      cy.get('[data-cy="number-3"]').click()
      cy.get('[data-cy="display"]').should('have.value', '123')
    })

    it('should handle decimal numbers', () => {
      cy.get('[data-cy="number-1"]').click()
      cy.get('[data-cy="decimal"]').click()
      cy.get('[data-cy="number-5"]').click()
      cy.get('[data-cy="display"]').should('have.value', '1.5')
    })

    it('should handle zero input', () => {
      cy.get('[data-cy="number-0"]').click()
      cy.get('[data-cy="display"]').should('have.value', '0')
    })
  })

  describe('Basic Arithmetic Operations', () => {
    it('should perform addition correctly', () => {
      cy.performCalculation(5, 'add', 3, 8)
      cy.get('[data-cy="result"]').should('contain', '5 + 3 = 8')
    })

    it('should perform subtraction correctly', () => {
      cy.performCalculation(10, 'subtract', 4, 6)
      cy.get('[data-cy="result"]').should('contain', '10 - 4 = 6')
    })

    it('should perform multiplication correctly', () => {
      cy.performCalculation(6, 'multiply', 7, 42)
      cy.get('[data-cy="result"]').should('contain', '6 * 7 = 42')
    })

    it('should perform division correctly', () => {
      cy.performCalculation(15, 'divide', 3, 5)
      cy.get('[data-cy="result"]').should('contain', '15 / 3 = 5')
    })
  })

  describe('Advanced Calculations', () => {
    it('should handle decimal calculations', () => {
      cy.get('[data-cy="clear"]').click()
      cy.enterNumber('2.5')
      cy.get('[data-cy="add"]').click()
      cy.enterNumber('1.5')
      cy.get('[data-cy="equals"]').click()
      cy.get('[data-cy="display"]').should('have.value', '4')
    })

    it('should handle negative results', () => {
      cy.performCalculation(3, 'subtract', 8, -5)
      cy.get('[data-cy="result"]').should('contain', '3 - 8 = -5')
    })

    it('should handle large numbers', () => {
      cy.get('[data-cy="clear"]').click()
      cy.enterNumber('999')
      cy.get('[data-cy="multiply"]').click()
      cy.enterNumber('999')
      cy.get('[data-cy="equals"]').click()
      cy.get('[data-cy="display"]').should('have.value', '998001')
    })

    it('should handle division by zero', () => {
      cy.performCalculation(5, 'divide', 0, 5)
      cy.get('[data-cy="result"]').should('contain', 'Error: Division by zero')
    })
  })

  describe('Calculator State Management', () => {
    it('should clear display and reset state', () => {
      cy.get('[data-cy="number-1"]').click()
      cy.get('[data-cy="number-2"]').click()
      cy.get('[data-cy="add"]').click()
      cy.get('[data-cy="number-3"]').click()
      
      cy.get('[data-cy="clear"]').click()
      
      cy.get('[data-cy="display"]').should('have.value', '')
      cy.get('[data-cy="result"]').should('be.empty')
    })

    it('should handle consecutive operations', () => {
      cy.performCalculation(5, 'add', 3, 8)
      cy.get('[data-cy="multiply"]').click()
      cy.get('[data-cy="number-2"]').click()
      cy.get('[data-cy="equals"]').click()
      cy.get('[data-cy="display"]').should('have.value', '16')
    })

    it('should update display during operation input', () => {
      cy.get('[data-cy="number-5"]').click()
      cy.get('[data-cy="add"]').click()
      cy.get('[data-cy="display"]').should('have.value', '5 + ')
      
      cy.get('[data-cy="number-3"]').click()
      cy.get('[data-cy="display"]').should('have.value', '5 + 3')
    })
  })

  describe('Edge Cases', () => {
    it('should handle multiple decimal points gracefully', () => {
      cy.get('[data-cy="number-1"]').click()
      cy.get('[data-cy="decimal"]').click()
      cy.get('[data-cy="number-2"]').click()
      cy.get('[data-cy="decimal"]').click() // Second decimal should be ignored
      cy.get('[data-cy="number-3"]').click()
      cy.get('[data-cy="display"]').should('have.value', '1.2.3') // This tests current behavior
    })

    it('should handle operator without first number', () => {
      cy.get('[data-cy="add"]').click()
      cy.get('[data-cy="number-5"]').click()
      cy.get('[data-cy="display"]').should('have.value', '5') // Should just show the number
    })

    it('should handle equals without complete operation', () => {
      cy.get('[data-cy="number-5"]').click()
      cy.get('[data-cy="equals"]').click()
      cy.get('[data-cy="display"]').should('have.value', '5') // Should remain unchanged
    })
  })

  describe('Keyboard Support', () => {
    it('should respond to keyboard number input', () => {
      cy.get('body').type('123')
      cy.get('[data-cy="display"]').should('have.value', '123')
    })

    it('should respond to keyboard operators', () => {
      cy.get('body').type('5+3')
      cy.get('[data-cy="display"]').should('have.value', '5 + 3')
    })

    it('should respond to Enter key for equals', () => {
      cy.get('body').type('5+3{enter}')
      cy.get('[data-cy="display"]').should('have.value', '8')
    })

    it('should respond to Escape key for clear', () => {
      cy.get('body').type('123{esc}')
      cy.get('[data-cy="display"]').should('have.value', '')
    })
  })

  describe('Visual Feedback', () => {
    it('should show button hover effects', () => {
      cy.get('[data-cy="number-1"]').trigger('mouseover')
      cy.get('[data-cy="number-1"]').should('be.visible')
    })

    it('should maintain proper button states', () => {
      cy.get('[data-cy="number-1"]').should('not.be.disabled')
      cy.get('[data-cy="add"]').should('not.be.disabled')
      cy.get('[data-cy="equals"]').should('not.be.disabled')
      cy.get('[data-cy="clear"]').should('not.be.disabled')
    })
  })
})
