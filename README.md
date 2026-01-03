# Employee Task Payroll Application

This project is developed as a term project for the SWE201 course.

It is a simple console application that imitates a basic employee task assignment and payroll calculation system.  
The application is designed as a toy project to demonstrate object-oriented programming concepts rather than to serve as a full-scale business solution.

---

## Project Purpose

The purpose of this project is to model real-life objects using classes and to simulate basic operations such as:
- Assigning tasks to employees
- Completing tasks through class methods
- Calculating employee salaries based on completed work

The project focuses on clarity and simplicity while following object-oriented design principles.

---

## Class Design Approach

While designing the classes, the following principles were applied:

- Each class represents a real-life object
- Only necessary attributes and properties are included
- Objects are modified through class methods instead of direct initialization
- No unused variables or empty methods are defined
- The design keeps a minimal structure suitable for testing and demonstration purposes

---

## Classes Used

### Employee
Represents an employee working in the company.

**Identifying attributes:**
- Id
- Name

**Operational properties:**
- HourlyRate
- AssignedTasks

Employees receive tasks during program execution using class methods.

---

### EmployeeTask
Represents a task assigned to an employee.

**Properties:**
- Title
- HoursWorked
- IsCompleted

Tasks are completed by calling a method that assigns working hours and updates task status.

---

### Payroll
Handles salary calculations.

This class calculates the total salary of an employee based on:
- Completed tasks
- Employee hourly rate

Salary calculation logic is separated from employee and task definitions.

---

## Program Flow

1. Employee objects are created.
2. Task objects are created.
3. Tasks are assigned to employees.
4. Tasks are completed by providing worked hours.
5. Payroll calculates the total salary.
6. Results are displayed in the console.

The Program class is used only to simulate the workflow of the application.

---

## Notes

This application uses predefined values and simulated scenarios.  
It is intended for educational purposes to demonstrate object-oriented programming and class relationships.
