# Student Information System

A simple Student Information System built using C# and SQL Server. The application allows users to view, add, and delete student records from a database. The data is displayed in a DataGridView for easy viewing and interaction.

## Features

- **View Student Data**: Display all student records stored in the database.
- **Add Student**: Add new student records to the database.
- **Delete Student**: Delete student records from the database.
- **Cancel Operation**: Close the form gracefully without any changes.

## Prerequisites

Before running the application, ensure you have the following installed:

- **Microsoft Visual Studio**: For building and running C# applications.
- **SQL Server (LocalDB)**: The application uses a local database (`MSSQLLocalDB`) for storing and managing student information.
- **.NET Framework**: The application is built using the .NET framework.

## Setup

1. **Clone the Repository**:
   Clone this repository to your local machine using the following command:
   ```bash
   git clone https://github.com/your-username/Student-Information-System.git
Install SQL Server LocalDB: Ensure that SQL Server LocalDB is installed and running on your machine. You can install it via the Visual Studio installer or from the official Microsoft site.

Set Up the Database:

Create a new database named studentinfodb.
Create a table studentab with the following structure:
sql
Copy code
CREATE TABLE studentab (
    id INT PRIMARY KEY,
    Stname NVARCHAR(100),
    age INT,
    email NVARCHAR(100)
);
Configure the Connection String:

Open the Form1.cs file.
Locate the connection string in the code and ensure it matches your SQL Server setup. The default connection string for LocalDB is:
csharp
Copy code
@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=studentinfodb;Integrated Security=True"
Build and Run the Application: Open the project in Visual Studio, build it, and run the application. The form will open, and you will be able to add, view, and delete student records.

Usage
Add Student: Enter the student's details (ID, Name, Age, and Email) in the respective text boxes and click the "Add" button.
View Students: All student records are displayed in the DataGridView on the form. You can view all data after loading the form or by clicking the "Refresh" button.
Delete Student: Select a student from the DataGridView and click the "Delete" button to remove that record from the database.
Cancel Operation: Click the "Cancel" button to close the form without making any changes.
License
This project is licensed under the MIT License - see the LICENSE file for details.

Acknowledgements
The application uses SQL Server LocalDB for managing student records.
Built with C# and Windows Forms.
Contributing
Feel free to fork this repository and submit pull requests for any enhancements or bug fixes. Contributions are welcome!

Contact
If you have any questions or suggestions, feel free to contact me via GitHub or email.

markdown
Copy code

---

### Explanation of Sections:

1. **Project Overview**: A brief description of the project and its main features.
2. **Prerequisites**: Information about the tools and software required to run the project.
3. **Setup Instructions**: Steps to clone the repo, set up the database, and configure the application.
4. **Usage**: How to interact with the application and perform operations.
5. **License**: A section that informs users about the licensing terms for the project. You can add a specific license if you wish.
6. **Contributing**: Instructions for anyone who wants to contribute to the project.
7. **Contact**: Information on how to reach out for queries or suggestions.

### Customization:
- Update the GitHub repository link in the "Clone the Repository" section with your actual GitHub link.
- Customize the email and any other details specific to your project or preferences.
