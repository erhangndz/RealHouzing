# RealHouzing - Real Estate Management API

**RealHouzing** is a comprehensive real estate management system built with **ASP.NET Core 6.0**, following a multi-tier architecture. It includes an API layer for managing real estate data and an API consumption layer for building user-facing interfaces. The application supports CRUD operations for properties and other real estate-related entities, and includes an **admin panel** for managing content and sending emails to users.

## Features

- **Multi-tier Architecture**:
  - Separation of concerns with distinct layers for API, Business Logic, Data Access, and UI.
  
- **Admin Panel**:
  - Admins can manage properties, users, and other resources.
  - Ability to send emails to users directly from the admin panel.

- **API Layer**:
  - Provides RESTful API endpoints for CRUD operations on real estate entities like properties, categories, and more.
  
- **API Consumption**:
  - A front-end layer that consumes the API and presents data to users.

- **Dynamic Entity Management**:
  - Supports dynamic property listings, including operations such as filtering, sorting, and detailed views.

## Technologies Used

- **ASP.NET Core 6.0**: For building the API and server-side logic.
- **Entity Framework Core**: For data access and database management.
- **MSSQL**: Database system for storing property and user data.
- **HTML/CSS/Bootstrap**: Frontend technologies for building responsive user interfaces.
  
## Project Structure

- **ApiLayer**: Contains controllers for handling API requests (e.g., `WhatWeDoController` for managing specific services).
- **BusinessLayer**: Implements business logic and rules.
- **DataAccessLayer**: Manages database operations through repositories.
- **DtoLayer**: Defines Data Transfer Objects for exchanging data between layers.
- **Consume**: Front-end application consuming the API for presenting data to users.

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/erhangndz/RealHouzing.git
