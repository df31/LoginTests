import { Given, When, Then } from "cypress-cucumber-preprocessor/steps";

const url = 'https://the-internet.herokuapp.com/login'
const successMessage = 'You logged into a secure area!'
const invalidUsernameMsg = 'Your username is invalid!'
const invalidPasswordMsg = 'Your password is invalid!'

Given('user typed in {string} and {string}', (username, password) => {
    cy.visit(url)
    cy.get('#username').as('usernameInput')
    username === '' ? cy.get('@usernameInput').focus().blur() : cy.get('@usernameInput').type(username)
    /*    cy.get('@usernameInput').type(username)*/
    cy.get('@usernameInput').should('have.attr', 'name', 'username')
    cy.get('@usernameInput').should('have.attr', 'type', 'text')
    cy.get('#password').as('pwdInput')
    password === "" ? cy.get('@pwdInput').focus().blur() : cy.get('@pwdInput').type(password)

    cy.get('@pwdInput').should('have.attr', 'name', 'password')
    cy.get('@pwdInput').should('have.attr', 'type', 'password')
})

When('the credential is submitted', () => {
    cy.get('button[class="radius"]').as('loginBtn')
    cy.get('@loginBtn').should('have.attr', 'type', 'submit')
    cy.get('@loginBtn').click()
})

Then('{string} is showed', (errorMessage) => {
    cy.get('#flash').as('errorMsg')
    cy.get('@errorMsg').should('have.class', 'flash error')
    cy.get('@errorMsg').should(($errorMsg) => {
        expect($errorMsg).to.contain(errorMessage)
    })
})

Then('login process should be success', () => {
    cy.url().should('eq', 'https://the-internet.herokuapp.com/secure')
    cy.get('#flash').as('successMsg')
    cy.get('@successMsg').should('have.class', 'flash success')
    cy.get('@successMsg').should(($successMsg) => {
        expect($successMsg).to.contain(successMessage)
    })

})