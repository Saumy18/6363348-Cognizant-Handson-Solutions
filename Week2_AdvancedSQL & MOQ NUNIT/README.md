
Week 2 - Advanced SQL, Moq, and NUnit Hands-on Solutions
📚 Overview
This repository contains hands-on solutions for Week 2: Advanced SQL, Moq, and NUnit as part of the Cognizant training program.
The goal is to develop practical expertise in:

Writing and optimizing advanced SQL queries.

Implementing unit testing with NUnit.

Creating service mocks using the Moq framework.

The project is structured into distinct modules for better learning and maintainability.

1. 📂 Advanced SQL
Overview
This module contains complex SQL scripts focusing on advanced query writing skills essential for database-driven applications and reporting tasks.

Topics Covered
Joins: INNER, LEFT, RIGHT, FULL

Subqueries: Correlated and Non-Correlated

Aggregations and Grouping

Window Functions (ROW_NUMBER, RANK, PARTITION BY)

Common Table Expressions (CTE)

How to Run
Open the SQL scripts in SQL Server Management Studio (SSMS) or any compatible SQL environment.

Ensure relevant sample datasets are loaded.

Execute the scripts and validate outputs.

2. 📂 MoqMailSenderTest
Overview
This module demonstrates mocking external services using the Moq framework. The primary use case is to simulate an email sender service and validate its behavior without sending real emails.

Key Features
Creation of Email Sender Interface

Moq-based service mocking

Unit tests to verify service invocation and parameters

How to Run
Open the solution in Visual Studio.

Ensure Moq and NUnit packages are installed via NuGet.

Run the unit tests using Visual Studio's Test Explorer.

3. 📂 NUnitCalculatorTest
Overview
This module provides NUnit-based unit tests for a simple calculator application. It focuses on verifying arithmetic operations and exception handling.

🛠 Technologies Used
SQL Server
C# (.NET Framework / .NET Core)
NUnit Testing Framework
Moq Mocking Framework

👤 Author
Saumy Raj

📄 License
This project is licensed under the MIT License. See the LICENSE file for details.
