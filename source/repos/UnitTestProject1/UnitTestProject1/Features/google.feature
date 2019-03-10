@first
Feature: google
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Search Google
	Given I am on google
	When I search "Automation"
	Then I should see the result
