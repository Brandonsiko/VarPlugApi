
# 🎓 Varsity Plug

**Varsity Plug** is an application designed to assist prospective students in South Africa by providing valuable information and resources related to university education. The app offers a variety of features to help users make informed decisions about their academic and career paths.

## 📚 Features

- **University Listings**: Discover universities based on your desired career path.
- **Varsity Residences**: Explore available varsity residences.
- **APS Score Qualification**: Determine your eligibility for specific modules or faculties based on your APS score.
- **Career Demand**: Find out which careers are currently in demand in South Africa.
- **Funding Opportunities**: Get information about available funding opportunities.

## 🛠️ Technologies Used

- **Frontend**: HTML, CSS
- **Backend**: C#, .NET
- **Database**: MySQL

## 🚀 Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Brandonsiko/VarPlugApi
   cd varsity-plug
   ```

2. **Install backend dependencies**:
   ```bash
   cd backend
   dotnet restore
   ```

3. **Set up the database**:
   - Ensure MySQL is installed and running.
   - Create a new database for the project.
   - Update the connection string in the backend configuration files to point to your MySQL database.

## 📦 Usage

### Running the Backend

1. **Start the .NET API server**:
   ```bash
   cd backend
   dotnet run
   ```

2. **The API server** will be available at `http://localhost:5000`.

### Running the Frontend

1. **Open the HTML file** in your browser:
   - Navigate to the `frontend` directory.
   - Open `index.html` in your preferred web browser.

## ⚙️ Configuration

- **Database Setup**:
  - Ensure you have MySQL installed and running.
  - Update the connection strings in the backend configuration files.

- **API Keys**:
  - Obtain necessary API keys for external integrations and update the environment variables.

## 🧪 Testing

### Backend

1. **Run tests**:
   ```bash
   cd backend
   dotnet test
   ```

## 🤝 Contribution

Contributions are welcome! Please fork the repository and create a pull request with your changes.

## 📄 License

This project is built and currently being maintained by Jayson.

---

