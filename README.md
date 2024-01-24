# Ability Score Calculator - Readme

## Overview
This console application is an implementation of an Ability Score Calculator, inspired by the concepts introduced in Chapter 4 of the Head First C# book, focusing on types and references. The application is designed to calculate an ability score based on user input for a Dungeons & Dragons-like character creation system.

## Learning Objective
As an experienced developer, creating this application serves the purpose of identifying and addressing any potential gaps in skills related to:

1. **User Input Handling:** The program uses the `ReadResponses` class to prompt users for various inputs, such as the starting roll, divide-by factor, additional amount, and minimum score. This reinforces the ability to manage user interactions in a console application.

2. **Basic Calculation Logic:** The `AbilityScoreCalculator` class contains the logic for calculating the ability score. This involves performing mathematical operations, parsing values, and setting the final score based on specific conditions. This reinforces fundamental skills in algorithmic thinking and logic implementation.

3. **Error Handling:** The application includes basic error handling to ensure that user inputs are valid. The `ReadResponses` class uses `int.TryParse` and `double.TryParse` to handle parsing errors, demonstrating a robust approach to input validation.

4. **Looping and Control Flow:** The application is designed to run continuously until the user decides to quit by pressing 'Q' or 'q'. This reinforces skills related to loop structures and control flow.

## Getting Started
To run the application:

1. Copy and paste the provided code into your preferred C# development environment.
2. Ensure you have the `AbilityScoreTester` namespace available or modify the code accordingly.
3. Run the application and follow the prompts to input values for the ability score calculation.

## Key Components
- **AbilityScoreCalculator:** This class contains the core logic for calculating the ability score based on user-defined parameters.

- **ReadResponses:** A utility class providing methods to read and parse user inputs for integers and doubles, with error handling.

## Reflection
As an experienced developer, reflect on the following aspects:

- **Design Decisions:** Evaluate the design choices made in terms of code organization, class responsibilities, and separation of concerns.

- **Error Handling:** Consider the effectiveness of the error handling mechanisms and whether they cover a broad range of potential user input scenarios.

- **Code Readability:** Assess the code's readability and clarity. Identify any areas for improvement in terms of code structure and documentation.

By engaging with this exercise, you can identify areas where you feel confident and areas that may require further exploration or improvement, ultimately enhancing your overall programming proficiency.
