# ChatGPT WebAPI Integration with .NET

This repository provides a concise guide on integrating ChatGPT into a .NET WebAPI solution. For a complete article in Italian, visit [cosminirimescu.com](https://cosminirimescu.com).

## Prerequisites

Ensure you have the following installed:
- Visual Studio
- .NET SDK
- An OpenAI account with API access

## Getting Started

### 1. Clone the Repository

Clone this repository to your local machine using:
```bash
git clone https://github.com/irimescucosmin/GPT.NET.git
cd GPT.NET
```

### 2. Install Dependencies
Navigate to the project directory and restore the dependencies:

```bash
dotnet restore
```

### 3. Configure the API Key
Obtain an API key from OpenAI and add it to the appsettings.json file:

```bash
{
  "OpenAI": {
    "ApiKey": "YOUR_OPENAI_API_KEY"
  }
}
```

### 4. Build and Run the Application
Build and run the application using:

```bash
dotnet build
dotnet run

```

### 5. Test the API with SwaggerUI
Open a browser and navigate to https://localhost:5001/swagger to access SwaggerUI.
From SwaggerUI, you can test the available endpoints:

#### 1. Get Available Models:

- Endpoint: GET /GPT/Models
Click "Try it out" and then "Execute".
#### 2. Send a Prompt to ChatGPT:

- Endpoint: GET /GPT/Ask
Click "Try it out".
Enter a prompt and optionally specify a model.
Click "Execute".


## Project Structure

```bash
GPT.NET/
├── Controllers/
│   └── GPTController.cs
├── Interfaces/
│   └── IGTPService.cs
├── Services/
│   └── GPTService.cs
├── appsettings.json
├── Program.cs
├── Startup.cs
└── ...
```

## Important Notes
- API Costs: Using the OpenAI API incurs costs. If you receive a 429 error, it likely means your available credit is exhausted. Recharge your account on the OpenAI platform.
- Security: Ensure your API key is securely stored and not exposed in your codebase.

## Contributing
Feel free to submit issues or pull requests if you have suggestions for improvements or new features.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Contact
For any inquiries or support, please contact hello@cosminirimescu.com.

Happy coding! Let's make our applications smarter with ChatGPT and .NET. For the full article in Italian, visit cosminirimescu.com.