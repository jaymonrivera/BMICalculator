# BMI Calculator Project

This project contains a BMI calculator service with accompanying unit tests using NUnit. The project includes an API to calculate BMI based on weight(kg) and height(cm) and determine the BMI category.

## Project Structure

- `BMICalculator`: The main project containing the BMI calculation logic and enums.
- `BMICalculator.Tests`: The test project containing unit tests for the BMI calculator service.

## Prerequisites

Ensure that you have the following installed:
- [.NET SDK](https://dotnet.microsoft.com/download) (Version 6.0 or later)
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) or another IDE with .NET support
- [NUnit](https://nunit.org/),  [NUnit3TestAdapter](https://www.nuget.org/packages/NUnit3TestAdapter/) and  [Moq](https://www.nuget.org/packages/Moq/4.20.70/) for running tests

## Building the Project

To build the project, follow these steps:

1. **Clone the Repository**

   ```bash
   git clone https://github.com/jaymonrivera/BMICalculator.git
   cd BMICalculator
   
2. **Restore Dependencies**
   ```bash
   dotnet restore

3. **Build the Solution**
   ```bash
   dotnet build

## Running the Project
1. **Run the Application**

   Navigate to the API project directory and run.
   
   ```bash
   dotnet run --project BMICalculator/BMICalculator.csproj

2. **Access the API**

   Use the swagger
   ```
   https://localhost:7116/swagger/index.html
   
