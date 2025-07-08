# Polymorphic Bonus Calculator

A demonstration project showing how to handle employee bonus calculations using polymorphism and C# interfaces, avoiding conditional statements.

## Overview

This project implements a simple employee management system that calculates salaries and bonuses for different types of employees (Manager, Intern, and regular Employee) using object-oriented principles and clean code practices.

## Features

- Type-safe employee creation using factory pattern
- Polymorphic bonus calculation
- Support for different employee types:
    - Manager
    - Intern
    - Regular Employee

## Project Structure

- `Employee.cs` - Base employee class
- `IBonusCalculable.cs` - Interface for bonus calculation
- `EmployeeFactory.cs` - Factory for creating different types of employees
- `EmployeeTypeEnum.cs` - Enum defining available employee types
- Concrete employee classes:
    - `Manager.cs`
    - `Intern.cs`
    - `RegularEmployee.cs`

## Design Patterns Used

1. **Factory Pattern**: Used for creating different types of employees
2. **Strategy Pattern**: Different bonus calculation strategies implemented through the `IBonusCalculable` interface
3. **Polymorphism**: Used to handle different employee types without conditional statements

## Prerequisites

- .NET 9.0
- C# 13.0

## Getting Started

1. Clone the repository
2. Open the solution in your preferred IDE (Visual Studio, Rider, etc.)
3. Build and run the project

## Benefits of this Implementation

- Eliminates the need for conditional statements when calculating bonuses
- Makes adding new employee types easier (Open/Closed Principle)
- Provides type safety through the factory pattern
- Clean and maintainable code structure

## Contributing

Feel free to submit issues and enhancement requests!

## License

[Add your chosen license here]