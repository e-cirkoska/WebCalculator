Feature: Advanced calculator
    As a user,
    I want to use the web calculator to find square root, square power, cube root, inverse, factorial and constants values,
    So that I can perform advanced calculator operations

@sqrt324
Scenario: Calculate square root of 324
	Given the user opens the calculator page
	And the user enters the number 324
	When the user clicks on the square root button
	Then the result is 18

@sqpow23
	Scenario: Calculate square power of 23
	Given the user opens the calculator page
	And the user enters the number 23
	When the user clicks on the square power button
	Then the result is 529

@cubert2744
	Scenario: Calculate cube root of 2744
	Given the user opens the calculator page
	And the user enters the number 2744
	When the user clicks on the cube root button
	Then the result is 14

@inverse8
	Scenario: Calculate inverse of 8
	Given the user opens the calculator page
	And the user enters the number 8
	When the user clicks on the inverse button
	Then the result is 0 point 125

@factorial7
	Scenario: Calculate factorial of 7
	Given the user opens the calculator page
	And the user enters the number 7
	When the user clicks on the factorial button
	Then the result is 5040

@factorial0
    Scenario: Calculate factorial of 0
	Given the user opens the calculator page
	And the user enters the number 0
	When the user clicks on the factorial button
	Then the result is 1

@euler9Decimals
    Scenario: Calculate value of euler constant
	Given the user opens the calculator page
	When the user clicks on the e constant button
	Then the result up to the 9th decimal point is correct

@pi14Decimals
	Scenario: Calculate value of PI constant
	Given the user opens the calculator page
	When the user clicks on the pi constant button
	Then the result up to the 14th decimal point is correct