# C# Calculator

A console-based calculator application developed with C# and .NET.

The project was built with a focus on clean code, object-oriented programming,
SOLID principles, dependency injection, and database persistence.

## Features

- Addition
- Subtraction
- Multiplication
- Division
- Division by zero validation
- Calculation history
- Clear calculation history
- Input validation
- SQLite database persistence

## Technologies

- C#
- .NET
- Entity Framework Core
- SQLite
- Dependency Injection
- Git / GitHub

## Architecture

The project separates responsibilities into different layers:

```text
Program
   |
   v
CalculatorApp
   |
   +----> CalculatorUI
   |
   +----> ICalculatorService
   |           |
   |           v
   |    CalculatorService
   |
   +----> ICalculationRepository
               |
               v
      CalculationRepository
               |
               v
          AppDbContext
               |
               v
             SQLite