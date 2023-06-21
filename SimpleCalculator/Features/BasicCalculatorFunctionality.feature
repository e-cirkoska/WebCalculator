Feature: Basic calculator
    As a user,
    I want to use the web calculator to add, subtract, multiply, and divide numbers,
    So that I can perform basic calculator operations

@addition3&8
Scenario: Add 3 and 8
	Given the user opens the calculator page
    And the user enters number 3
    And the user clicks on the plus button
    And the user enters number 8
    When the user clicks on the equals sign
    Then the result is 11

 @addition24&19
Scenario: Add 24 and 19
	Given the user opens the calculator page
    And the user enters number 24
    And the user clicks on the plus button
    And the user enters number 19
    When the user clicks on the equals sign
    Then the result is 43

@substraction13&37
Scenario: Substract 37 from 13
	Given the user opens the calculator page
    And the user enters number 13
    And the user clicks on the minus button
    And the user enters number 37
    When the user clicks on the equals sign
    Then the result is negative 24

@substraction7&2
Scenario: Substract 2 from 7
	Given the user opens the calculator page
    And the user enters number 7
    And the user clicks on the minus button
    And the user enters number 2
    When the user clicks on the equals sign
    Then the result is 5

@multiplication5&3
Scenario: Multiply 5 by 3
	Given the user opens the calculator page
    And the user enters number 5
    And the user clicks on the multiply button
    And the user enters number 3
    When the user clicks on the equals sign
    Then the result is 15

@multiplication23&47
Scenario: Multiply 23 by 47
	Given the user opens the calculator page
    And the user enters number 23
    And the user clicks on the multiply button
    And the user enters number 47
    When the user clicks on the equals sign
    Then the result is 1081

@division11&2
Scenario: Divide 11 by 2
	Given the user opens the calculator page
    And the user enters number 11
    And the user clicks on the divide button
    And the user enters number 2
    When the user clicks on the equals sign
    Then the result is 5 point 5

@division3&0
Scenario: Divide 3 by 0
	Given the user opens the calculator page
    And the user enters number 3
    And the user clicks on the divide button
    And the user enters number 0
    When the user clicks on the equals sign
    Then the result is invalid input