# Veterinary Management System 🐾

Welcome to the **Veterinary Management System**, a platform designed to streamline pet, owner, and vaccine management in veterinary clinics.

---

##  Overview
The **Veterinary Management System** is a full-stack web application built using **.NET Core** and **SQL Server** to help veterinary clinics efficiently manage **pets, owners, and vaccination records**. It provides **CRUD functionalities, user authentication, and caching mechanisms** for optimal performance.

---

##  Features
-  **User Authentication & Authorization** – Admin and Regular User roles  
-  **Owner & Pet Management** – Create, Read, Update, and Delete records  
-  **Vaccine Tracking** – Assign multiple vaccines to pets  
-  **Caching Mechanism** – Enhances performance using **MemoryCache**  
-  **Database with Entity Framework Core** – Code-First approach using **SQL Server**  
-  **Clean Code & OOP Principles** – Following best practices in software design  
-  **Unit Testing** – Ensuring system reliability and robustness  

---

##  User Roles
| Role | Permissions |
|------|------------|
| **Admin** | Full control (CRUD operations) |
| **Regular User** | Limited access (can view & create pets) |

---

##  Installation & Setup

###  **Prerequisites**
- .NET 6+
- SQL Server
- Visual Studio

###  **Setup Steps**
 
```sh
# Clone the repository
git clone https://github.com/codeek123/Veterinary_App_Semos.git

# Navigate to the project folder
cd veterinary-app

# Run migrations and update the database
dotnet ef migrations add Initial1
dotnet ef database update

# Run the application
dotnet run


```
###  **Technologies Used**

| **Component**  | **Technology**  |  
|---------------|----------------|  
| **Backend**   | ASP.NET Core MVC, Entity Framework Core |  
| **Database**  | SQL Server |  
| **Frontend**  | Razor Views (Bootstrap for styling) |  
| **Caching**   | MemoryCache for optimized data retrieval |  



