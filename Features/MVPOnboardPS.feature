Feature: MVPOnBoardPS Test Suite

    As a user
    I want to navigate to the Mars page
    So that I can create and save a new language record

Scenario: Create a New Language
	Given User logs into the portal
	And user navigates to language page
	When user creates a new language
	Then portal should save the language
