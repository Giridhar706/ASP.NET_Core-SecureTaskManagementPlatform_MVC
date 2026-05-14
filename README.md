# Secure Task Management Platform

## Overview

Secure Task Management Platform is a secure ASP.NET Core MVC web application developed to demonstrate authentication, authorization, session management, and secure coding practices.

The application implements forms-based authentication, role-based authorization, claims-based access control, CSRF protection, XSS prevention, secure cookie handling, HTTPS enforcement, and secure logout functionality.

---

# Features

## Authentication
- User Registration
- Secure Login
- Secure Logout
- Cookie-Based Authentication

---

## Authorization
- Role-Based Authorization
- Claims-Based Authorization
- Admin Access Control
- Authorization Policies

---

## Security Features
- CSRF Protection using Anti-Forgery Tokens
- XSS Prevention using Output Encoding
- Secure Session Management
- Secure Cookie Configuration
- HTTPS Enforcement
- BCrypt Password Hashing
- Input Validation using Data Annotations

---

# Technologies Used

- ASP.NET Core MVC
- C#
- Entity Framework Core
- In-Memory Database
- Razor Views
- Cookie Authentication
- BCrypt.Net

---

# Project Structure

```bash
SecureTaskManagementPlatform
│
├── Controllers
├── Models
├── Views
├── Data
├── Program.cs
└── SecureTaskManagementPlatform.csproj
```

---

# Roles Implemented

## Admin
Can access:
- `/Admin/ManageTasks`

## User
Can access:
- `/User/TaskList`
- `/User/CreateTask`

---

# Claims-Based Authorization

Users are assigned:
```text
CanEditTask = true
```

This enables task creation/edit permissions using authorization policies.

---

# Security Testing

## XSS Prevention Test

Enter:

```html
<script>alert('hack')</script>
```

Expected:
- Script should NOT execute
- Content displayed as encoded text

---

## SQL Injection Prevention Test

Enter:

```sql
' OR 1=1 --
```

Expected:
- Application behaves normally
- No SQL query manipulation occurs

---

# Session Security

- HttpOnly Cookies Enabled
- Secure Cookies Enabled
- HTTPS Enforced
- Session Timeout: 15 Minutes
- Secure Logout Implemented

---

# Test Credentials

## Admin Account

Email:
```text
admin@gmail.com
```

Password:
```text
Admin@123
```

---

## User Account

Email:
```text
user@gmail.com
```

Password:
```text
User@123
```

---

# Important Routes

| Feature | Route |
|---|---|
| Home | `/Home/Index` |
| Register | `/Account/Register` |
| Login | `/Account/Login` |
| Task List | `/User/TaskList` |
| Create Task | `/User/CreateTask` |
| Admin Panel | `/Admin/ManageTasks` |
| Logout | `/Account/Logout` |

---

# How To Run

1. Open `SecureTaskManagementPlatform.csproj`
2. Build Solution
3. Press `Ctrl + F5`

---

# Learning Outcomes

- ASP.NET Core MVC Architecture
- Secure Authentication
- Role-Based Authorization
- Claims-Based Authorization
- CSRF Protection
- XSS Prevention
- Secure Session Management
- Secure Logout
- HTTPS Security
- Secure Cookie Handling
- Entity Framework Core

---

# Author

Giridhar Gopal
