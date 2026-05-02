# 🛒 E-commerce Clean Architecture API

A scalable backend system built using ASP.NET Core following Clean Architecture principles.

---

## 🚀 Features

- ✅ Clean Architecture (Domain, Application, Infrastructure, API)
- 🔐 JWT Authentication & Role-based Authorization
- 📦 Product Management APIs
- ⚡ Async/Await for high performance
- 🗄️ Entity Framework Core integration
- 🐳 Docker support (coming / optional)
- 🚀 Designed for scalability and maintainability

---

## 🏗️ Architecture
EcommerceProject/
│
├── Ecommerce.API → Presentation Layer (Controllers)
├── Ecommerce.Application → Business Logic
├── Ecommerce.Domain → Entities & Core Models
├── Ecommerce.Infrastructure→ Database & External Services


---

## 🧰 Tech Stack

- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server (planned / optional)
- Docker (planned)
- Redis (planned)

---

## ▶️ How to Run

``bash
dotnet build
dotnet run --project Ecommerce.API

API will run at:

http://localhost:5105/api/Product


🎯 Future Improvements
Add Database (SQL Server)
Add Redis Caching
Implement Order & Payment Module
Add CI/CD Pipeline
Deploy using Docker & Kubernetes


👨‍💻 Author

Ashwani Arya


---
