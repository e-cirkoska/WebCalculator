Feature: CustomCalculatorFunctionality
    As a user,
    I want to be able to delete calculator entries,
    So that I can correct any mistakes that I have made during calculations

@xBtn
Scenario: Clear digit with X button
	Given the user opens the calculator page
	And the user enters the number negative 985
	When the user clicks on the X button
	Then the entry is negative 98

@ceBtn
Scenario: Clear entry with CE button
	Given the user opens the calculator page
	And the user adds negative 9 and 2 point 5 and pi
	And the user clicks on the CE button
	And the user enters the number 7
	When the user clicks on the equals sign
	Then the result is 0 point 5

@cBtn
Scenario: Clear everything with C button
	Given the user opens the calculator page
	And the user multiplies 25 by 6 and subtracts 12
	And the user clicks on the C button
	Then the result is 0
	And the complete calculation is deleted