Veterinary Management System
This is the final project from the Full Stack .NET Academy, designed for a veterinary clinic to efficiently manage Pets, Owners, and Vaccines. The system provides CRUD functionalities, authentication, and caching for optimal performance.

Features
User Authentication & Authorization: Admin and Regular User roles

Owner & Pet Management: Create, read, update, and delete owners and pets

Vaccine Tracking: Assign multiple vaccines to pets

Caching Mechanism: Improves performance by caching frequently accessed data

Database with Entity Framework Core: Code-First approach with SQL Server

Clean Code & OOP Principles: Following best practices in software design

Unit Testing: Ensuring system reliability

User Roles
Admin: Full control (CRUD operations)

Regular User: Limited access (view & create pets)

Installation & Setup
Prerequisites
.NET 6+

SQL Server

Visual Studio

Setup Steps
Clone the repository

sh
Copy
Edit
git clone https://github.com/codeek123/Veterinary_App_Semos.git
cd veterinary-app  
Set up the database

Configure appsettings.json with the SQL Server connection string

Run migrations:

sh
Copy
Edit
dotnet ef migrations add Initial1  
dotnet ef database update  

Run the application

sh
Copy
Edit
dotnet run  
Technologies Used
Backend: ASP.NET Core MVC, Entity Framework Core

Database: SQL Server

Frontend: Razor Views (Bootstrap for styling)

Caching: MemoryCache for optimized data retrieval

This system ensures efficient pet management, easy vaccine tracking, and secure access control, providing a seamless experience for veterinary clinics. 
