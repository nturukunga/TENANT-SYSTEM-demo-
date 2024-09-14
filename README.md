🏢 Tenant System
Version: 1.0
Language: VB.NET
IDE: Microsoft Visual Studio 2022
Database: MySQL (phpMyAdmin)
Theme: Dark

📚 Overview
The Tenant System is a desktop application designed to streamline tenant management by tracking tenant information, payment histories, and overdue accounts. Built using VB.NET in Microsoft Visual Studio 2022, this system aims to simplify managing rental payments and tenant details. With an intuitive user interface and strong backend integration with MySQL (via phpMyAdmin), this solution provides landlords with a reliable tool to manage their properties.

The black and orange theme adds an aesthetic and functional touch, ensuring good contrast and an attractive design.

💡 Features
🔐 Login System
Secure login with hashed passwords to prevent unauthorized access.
Only authorized users can access the tenant management dashboard.
👤 Tenant Management
Add tenants: Register new tenants with essential details like name, email, house number, phone, and address.
Delete tenants: Remove tenants who have moved out or completed their tenancy.
Update tenants: Edit tenant details directly from the system.
Real-time updates: Data refreshes instantly across the system when new tenants are added or information is updated.
💳 Payment Management
Track payments: Keep records of all payments made by tenants.
Default tracking: Monitor tenants who have defaulted on their payments, track how long they've owed rent, and show overdue amounts.
Defaulter reports: Generate reports showing tenants who haven't paid, including the period of default.
📊 DataGridView and ComboBoxes
DataGridView: Displays real-time data about tenants. Allows easy interaction and editing.
ComboBoxes: Used to select tenants and other details for various operations like deletion, updates, or filtering.
📅 Debt Reports
Debt management: Track overdue tenants and the amount they owe.
Debt history: Update tenant debt status and last payment dates.
🛠️ Tools & Technologies Used
📌 Programming Language
VB.NET: The main language used for building the application logic and user interface.
💻 Integrated Development Environment
Microsoft Visual Studio 2022: Provides a powerful environment to code, design the UI, and debug the project.
🗄️ Database System
MySQL: Stores tenant, payment, and defaulter data securely.

phpMyAdmin: Web-based database management system used for managing MySQL databases. The project interacts with MySQL for all database operations.

The MySQL database contains the following tables:

users: Stores login credentials and user information.
tenants: Contains tenant details (name, email, house number, phone, and address).
payments: Stores payment details such as amount, date, and method used.
debts: Tracks overdue payments and how long tenants have defaulted.
🔑 Security
Password hashing: User passwords are stored securely with hashing to prevent unauthorized access.
🎯 Problem It Solves
Managing tenants and payments manually, especially in large buildings or multiple properties, can be challenging. This system solves several issues:

Time-saving: Automates tasks like tenant management, payment tracking, and defaulter reporting, reducing the time spent on manual data entry.
Error reduction: Eliminates the chance of human error by handling tenant records, payments, and reports electronically.
Security: Ensures secure user authentication with password hashing, preventing unauthorized access to tenant and financial information.
Tenant visibility: Provides a clear and real-time overview of tenant details, payments made, and outstanding debts.
By streamlining these processes, landlords can focus on providing better services to tenants rather than dealing with manual records.

🎨 UI Design
Dark Theme: The black and orange theme is implemented to ensure clarity and aesthetic appeal, minimizing strain on the eyes during long usage sessions.

Here's a mockup of the system interface:


📂 Folder Structure
plaintext
Copy code
TenantSystem/
│
├── TenantSystem.sln              # Solution file
├── HomeFrm.vb                    # Main form for tenant management
├── LoginFrm.vb                   # Login form
├── TenantDatabase.sql            # MySQL database schema and seed data
└── README.md                     # Project documentation
🚀 Getting Started
🔧 Requirements
Microsoft Visual Studio 2022: To run and edit the VB.NET project.
MySQL: For the database. Set up via phpMyAdmin.
.NET Framework: Ensure the required version of .NET is installed for the project.
📥 Installation Steps
Clone the repository to your local machine:

bash
Copy code
git clone https://github.com/your-repo/TenantSystem.git
Open the solution file in Visual Studio 2022.

Set up the MySQL database:

Use phpMyAdmin to import the TenantDatabase.sql file provided in the project folder.
Make sure to adjust the connection string in your HomeFrm.vb file according to your MySQL setup (host, user, password).
Build and run the project in Visual Studio.

📝 Database Schema
sql
Copy code
CREATE TABLE `users` (
    `user_id` INT PRIMARY KEY AUTO_INCREMENT,
    `username` VARCHAR(100),
    `password_hash` VARCHAR(255)
);

CREATE TABLE `tenants` (
    `tenant_id` INT PRIMARY KEY AUTO_INCREMENT,
    `name` VARCHAR(100),
    `email` VARCHAR(100),
    `house_no` VARCHAR(50),
    `phone` VARCHAR(15),
    `address` VARCHAR(255)
);

CREATE TABLE `payments` (
    `payment_id` INT PRIMARY KEY AUTO_INCREMENT,
    `tenant_id` INT,
    `amount` DECIMAL(10, 2),
    `payment_date` DATE,
    `method` VARCHAR(50),
    FOREIGN KEY (tenant_id) REFERENCES tenants(tenant_id)
);

CREATE TABLE `debts` (
    `debt_id` INT PRIMARY KEY AUTO_INCREMENT,
    `tenant_id` INT,
    `debt_amount` DECIMAL(10, 2),
    `months_owed` INT,
    `last_payment_date` DATE,
    FOREIGN KEY (tenant_id) REFERENCES tenants(tenant_id)
);
🛡️ Security Measures
Hashed Passwords: We use a hashing algorithm to store passwords securely, ensuring no plain text passwords are saved.
MySQL Data Security: The application is configured to securely interact with MySQL using connection strings that are stored in the VB.NET application. Proper sanitation methods are applied to prevent SQL injection.
📈 Future Improvements
Notifications: Add functionality to notify users when tenants have overdue payments.
Reporting: Generate visual reports (graphs, charts) for rental income and outstanding debts.
Multi-property management: Expand to manage multiple properties under a single system.
👥 Contributors
Nturukunga - Developer & Designer

📞 Support
For any inquiries, issues, or contributions, feel free to contact us at:

Email: nturukunga@gmail.com 
GitHub: You are already here
Thank you for using the Tenant System! 🎉
We hope it makes tenant management easier and more efficient for you!

* Theme may change based on the changes I implement. Thank You

"Efficient management, one tenant at a time." 🏠
