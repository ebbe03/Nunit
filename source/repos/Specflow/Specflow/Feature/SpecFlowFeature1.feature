@app
Feature: Appbuilder service

@appbuilder
Scenario: Test Appbuilder authentication service
	Given I get appbuilder authentication service endpoint
	 Then I expect to see status 200
     Then I expect to see "Data Cube Import" in the response body
