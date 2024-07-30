# Varsity Plug
Varsity Plug is an application designed to assist prospective students in South Africa by providing valuable information and resources related to university education. The app offers a variety of features to help users make informed decisions about their academic and career paths.

Features
University Listings: Get a list of universities based on the career you want to pursue.
Varsity Residences: View available varsity residences.
APS Score Qualification: Check if you qualify for specific modules or faculties based on your APS score.
Career Demand: Find out which careers are currently in demand in South Africa.
Funding Opportunities: Discover available funding opportunities.
Technologies Used
Frontend: HTML, CSS
Backend: C#, .NET
Database: MySQL
Installation
Clone the repository:

bash
Copy code
git clone https://github.com/Brandonsiko/VarPlugApi
cd varsity-plug
Install backend dependencies:

bash
Copy code
cd backend
dotnet restore
Set up the database:

Ensure MySQL is installed and running.
Create a new database for the project.
Update the connection string in the backend configuration files to point to your MySQL database.
Usage
Running the Backend
Start the .NET API server:

bash
Copy code
cd backend
dotnet run
The API server will be available at http://localhost:5000.

Running the Frontend
Open the HTML file in your browser:
Navigate to the frontend directory.
Open index.html in your preferred web browser.
Configuration
Database Setup:
Ensure you have MySQL installed and running. Update the connection strings in the backend configuration files.

API Keys:
Obtain necessary API keys for external integrations and update the environment variables.

Testing
Backend
Run tests:
bash
Copy code
cd backend
dotnet test
Contribution
Contributions are welcome! Please fork the repository and create a pull request with your changes.

License
This project is licensed under the MIT License. See the LICENSE file for details.
