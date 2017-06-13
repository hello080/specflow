Feature: Login
	In order to verify login
	As invalid information used
	I want to log in and verify the error message
	
@invalid
Scenario: Login with invalid information
	Given I am on LiveGuru site
    And I quit browser

	# And I input username and password
	# When I click Login button
	# Then the error message should be displayed
