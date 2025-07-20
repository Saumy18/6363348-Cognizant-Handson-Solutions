# Week 5 – ASP.NET Web API & Microservices

This folder contains practical hands-on solutions for building a secure **ASP.NET Core 8.0 Web API** using **JWT Authentication** and microservice integration with **Apache Kafka**. 
This is part of the Week 5 deliverable for the Cognizant Hands-on Program.

---

## 🔧 Projects Included

### 1. **JWT Authentication in ASP.NET Core Web API**
- Secure REST API using JWT (JSON Web Token)
- Claims-based role validation (`Admin`, `User`)
- Token generation and validation
- Swagger documentation with `ProducesResponseType` annotations
- Tested with Swagger UI and Postman

### 2. **Kafka Integration with C#**
- ASP.NET Core-based producer and consumer microservices
- Kafka event publishing and subscription using `Confluent.Kafka` package
- Sample message processing workflow

---

## 🛠 Technologies & Tools Used

| Technology        | Version         |
|------------------|-----------------|
| .NET Core         | 8.0             |
| ASP.NET Core Web API | 8.0         |
| Kafka             | Apache Kafka + Confluent.Kafka |
| JWT               | System.IdentityModel.Tokens.Jwt |
| Swagger (Swashbuckle) | 6.x       |
| Visual Studio     | 2022            |
| Postman           | Latest          |

---

## 🔐 JWT Authentication Flow

1. **Login API** generates a JWT token upon valid credentials.
2. Token is returned and copied to Postman/Swagger.
3. Authorized endpoints require the token in the `Authorization: Bearer <token>` header.
4. Claims-based checks restrict access based on roles.

## 🚀 How to Run the API

### ✅ Prerequisites
- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022 (with ASP.NET workload)
- Kafka running locally (for Kafka project only)

---

### ▶️ Steps to Run JWT Project (`MyJwtAuthAPI`)

1. Open `MyJwtAuthAPI.sln` in Visual Studio.
2. Set `MyJwtAuthAPI` as the startup project.
3. Press `F5` to run the project.
4. Open browser at: `https://localhost:<port>/swagger`
📄 License
This repository is licensed under the Apache 2.0 License.

Contact
Github: https://github.com/Saumy18 LinkedIn: www.linkedin.com/in/saumy-raj-56b213257 Phone: +91 8294575219.
