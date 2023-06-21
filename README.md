# WebCalculator

This repository contains automation tests for a web calculator application written in SpecFlow with Selenium using C#. The tests are designed to verify the functionality and correctness of the calculator's operations.

## Installation

1. Clone this repository to your local machine using the following command:
https://github.com/e-cirkoska/WebCalculator.git

2. Ensure that you have the necessary prerequisites installed:
- .NET Framework 
- SpecFlow 
- Selenium WebDriver

3. Restore the NuGet packages

## Test Framework

The test framework used for this project combines SpecFlow, a behavior-driven development (BDD) tool, with Selenium WebDriver, a powerful web automation framework. The tests are written in Gherkin syntax, which allows easy collaboration between stakeholders, developers, and testers.

## Test Scenarios

The following test scenarios are included in this project:

1. Addition Test: Verifies that the addition operation of the calculator produces the correct result.
2. Subtraction Test: Ensures that the subtraction operation of the calculator functions correctly.
3. Multiplication Test: Validates the multiplication operation of the calculator.
4. Division Test: Tests the division operation of the calculator, checking for accurate results and proper handling of division by zero.
5. Square Root Test: Validates the square root operation of the calculator.
6. Square Power Test: Validates the square power operation of the calculator.
7. Cube Root Test: Validates the cube root operation of the calculator.
8. Inverse Test: Validates the inverse operation of the calculator.
9. Factorial Test: Validates the factorial operation of the calculator.
10. Constants Test: Finds the value of constants.
11. Clearing Entries Test: Validates that the entries are successfully deleted and the correctness of the operations after entries' deletion.

The scenarios are structured in three feature files:
- Basic calculator
- Advanced calculator
- Custom calculator (additional scenarios added for better test coverage)

Notes:
- The features can be run in parallel
- The tests can be run in any browser (Chrome, Firefox, Edge)
- Tests reports are generated

## Running the Tests

To run the tests, use Microsoft Visual Studio.

1. Open the solution file (`SimpleCalculator.sln`) in Microsoft Visual Studio.
2. Build the solution.
3. Open the Test Explorer window.
4. Click the "Run All" button in the Test Explorer window or run each test individually.



