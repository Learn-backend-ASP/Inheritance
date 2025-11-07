# C# Inheritance Concepts - Employee Management System

This project demonstrates various inheritance concepts in C# through an Employee Management System. Each concept is explained with real examples from the codebase.

## What, Why, and How of Inheritance

### What is Inheritance?
Inheritance is a fundamental Object-Oriented Programming concept that allows a class to inherit properties and methods from another class. The class that inherits is called the derived class (child), and the class being inherited from is called the base class (parent).

### Why Use Inheritance?
- Code reusability
- Establishes relationships between classes
- Reduces code duplication
- Enables polymorphic behavior

### How to Implement Inheritance
In C#, inheritance is implemented using the `:` symbol. Example from our project:

```csharp
public class Developer : Employee  // Developer inherits from Employee
{
    // Developer-specific members
}
```

## Casting and Conversion

In our project, we can cast between different employee types since they all inherit from the `Employee` base class. For example:

```csharp
Employee employee = new Developer("John", 1, 180, 50, true);  // Upcasting
Developer developer = (Developer)employee;                     // Downcasting
```

## Abstract Classes

An abstract class is a base class that cannot be instantiated and may contain abstract methods. While our project doesn't use abstract classes, here's how our `Employee` class could be made abstract:

```csharp
public abstract class Employee
{
    // ... existing code ...
}
```

## Sealed Classes

A sealed class prevents inheritance - no other class can inherit from it. While our project doesn't use sealed classes, any of our classes could be sealed to prevent further inheritance:

```csharp
public sealed class Developer : Employee
{
    // No class can inherit from Developer
}
```

## Virtual Functions

Virtual functions enable method overriding in derived classes. Our project uses this in the `Employee` class:

```csharp
protected virtual decimal Calculate()
{
    return CalculateBaseSalary() + CalculateOverTime();
}
```

Each derived class (`Developer`, `Sales`, `Manager`, `Maintenance`) overrides this method to add their specific calculations.

## Abstract Members

Abstract members must be implemented by derived classes. While our project doesn't use them, here's how we could make the `Calculate` method abstract:

```csharp
protected abstract decimal Calculate();  // Would require implementation in all derived classes
```

## Sealed Members

Sealed members prevent further overriding in derived classes. Our project could use this to prevent further modifications to calculation methods:

```csharp
public sealed override decimal Calculate()
{
    return base.Calculate() + CalculateBones();
}
```

## Object Class

Every class in C# inherits from the `Object` class. In our project, we override the `ToString()` method from the `Object` class in multiple classes:

```csharp
public override string ToString()
{
    return base.ToString() +
        $"\nHardship : ${Math.Round(hardship, 2):N0}" +
        $"\nNet Salary : ${Math.Round(this.Calculate(), 2):N0}";
}
```

## Constructor and Inheritance

Our project demonstrates constructor chaining using the `base` keyword:

```csharp
public Developer(string name, int id, decimal loggedHoures, decimal wage, bool taskCompleted) 
    : base(name, id, loggedHoures, wage)
{
    TaskCompleted = taskCompleted;
}
```

## Real World Example

Our project implements a real-world Employee Management System with different types of employees:

1. **Base Employee**: Contains common properties like Name, ID, LoggedHours, and Wage
2. **Developer**: Adds task completion bonus
3. **Sales**: Includes commission-based calculations
4. **Manager**: Adds allowance calculations
5. **Maintenance**: Includes hardship allowance

## Hiding Inherited Members

While our project primarily uses overriding, member hiding can be done using the `new` keyword. Example:

```csharp
// In base class
protected decimal Calculate() { ... }

// In derived class
protected new decimal Calculate() { ... }  // Hides base implementation
```

## Inheritance Hierarchy in Our Project

```
Employee (Base Class)
├── Developer
├── Sales
├── Manager
└── Maintenance
```

Each derived class inherits common functionality from the `Employee` class and adds its own specific features:
- `Developer`: Adds task completion bonus
- `Sales`: Adds commission-based calculations
- `Manager`: Adds allowance calculations
- `Maintenance`: Adds hardship allowance

This project demonstrates how inheritance helps in creating a well-organized, maintainable, and extensible codebase by leveraging code reuse and polymorphism.

---

**Author:** Mahmoud Hany  
**Language:** C#  
**Topic:** Inheritance
