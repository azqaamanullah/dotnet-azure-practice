# .NET 9 Blazor WebAssembly App with Automated CI/CD Pipeline

A modern, standalone Blazor application deployed to Microsoft Azure using automated DevOps practices.

## 🚀 Live Demo
🔗 [Click here to view the live deployed application](PASTE_YOUR_AZURE_STATIC_WEB_APP_URL_HERE)

## 🛠️ Tech Stack & Architecture
* **Frontend:** .NET 9.0 (C# / Blazor WebAssembly)
* **CI/CD Automation:** GitHub Actions (YAML Workflow)
* **Cloud Hosting:** Microsoft Azure Static Web Apps

## 🔄 DevOps Workflow
Every time code is pushed to the `main` branch, a GitHub Actions workflow container automatically triggers to run:
1. Production asset building (`dotnet publish`)
2. Automated environment packaging
3. Secure deployment straight to Azure Web Infrastructure via secret deployment tokens
