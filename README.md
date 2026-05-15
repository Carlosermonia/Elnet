# 🏥 MediTrack: Integrated Clinic Appointment & Patient Health Record System

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![SQLite](https://img.shields.io/badge/Database-SQLite-lightblue)
![WinForms](https://img.shields.io/badge/UI-Windows%20Forms-blue)
![EF Core](https://img.shields.io/badge/ORM-Entity%20Framework%20Core-purple)

## 📋 Project Overview

MediTrack is a C# .NET 8 desktop application designed to modernize small-to-medium clinic operations. It provides a unified interface for managing patient records, doctor information, and appointment scheduling — replacing traditional paper-based record-keeping with a secure, efficient digital solution.

---

## 👥 Developers

| Name | Role |
|------|------|
| Veloso, Ma. Isabel | Developer |
| Coronel, Ronalyn | Developer |
| Sermonia, John Carlo | Developer |

---

## 🚀 Features

### 🔐 Authentication & Security
- Secure login with BCrypt password hashing
- Role-based access control (Admin, Receptionist, Doctor)
- Account deactivation — deactivated users cannot log in

### 📊 Dashboard
- Real-time stats: Total Patients, Today's Appointments, Pending Appointments
- Today's Schedule notification on login
- Role-based menu visibility

### 👤 Master File Management
- **Patients** — Add, Edit, Delete, Search patient records
- **Doctors** — Add, Edit, Delete, Search doctor records with active/inactive status

### 📅 Transaction Module
- Appointment booking with conflict validation
- Edit and delete appointments
- Status tracking: Scheduled, Completed, Cancelled, No-Show
- Color-coded rows for quick visual reference
- Filter by date and status

### 📈 Reports
- Generate appointment summary reports by date range
- View patient, doctor, date, time, status, and consultation fee

### ⚙️ User Management
- Add, Edit, Deactivate, and Delete user accounts
- Role assignment: Admin, Receptionist, Doctor
- Admin account is protected from deletion

---

## 🛠️ Technology Stack

| Technology | Purpose |
|-----------|---------|
| C# .NET 8 | Programming language |
| Windows Forms (WinForms) | UI Framework |
| SQLite | Database |
| Entity Framework Core 8 | ORM / Database management |
| BCrypt.Net | Password hashing |
| Git / GitHub | Version control |

---

## 🗄️ Database Structure

```
Users
├── UserId (PK)
├── Username
├── PasswordHash
├── Role
└── IsActive

Patients
├── PatientId (PK)
├── FirstName
├── LastName
├── DateOfBirth
├── Gender
├── ContactNumber
├── Email
├── Address
├── MedicalHistory
└── CreatedAt

Doctors
├── DoctorId (PK)
├── FirstName
├── LastName
├── Specialization
├── ContactNumber
├── Email
└── IsActive

Appointments
├── AppointmentId (PK)
├── PatientId (FK)
├── DoctorId (FK)
├── AppointmentDate
├── TimeSlot
├── Status
├── ConsultationFee
└── Notes

Prescriptions
├── PrescriptionId (PK)
├── AppointmentId (FK)
├── Medication
├── Dosage
└── Instructions
```

---

## 👥 User Roles & Access

| Feature | Admin | Receptionist | Doctor |
|---------|-------|-------------|--------|
| Master Files | ✅ | ✅ | ❌ |
| Appointments | ✅ | ✅ | ✅ |
| Reports | ✅ | ✅ | ✅ |
| User Management | ✅ | ❌ | ❌ |
| Settings | ✅ | ❌ | ❌ |

---

## ⚙️ Installation & Setup

### Prerequisites
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with **.NET Desktop Development** workload
- [Git](https://git-scm.com/download/win)
- [DB Browser for SQLite](https://sqlitebrowser.org/dl/) *(optional — for viewing database)*

### Steps

**1. Clone the repository**
```bash
git clone https://github.com/Carlosermonia/Elnet.git
cd Elnet
```

**2. Open the project**
- Open `MediTrack.sln` in Visual Studio 2022

**3. Restore NuGet packages**
- Press `Ctrl + Shift + B` to build — packages restore automatically

**4. Create the database**
- Open **Package Manager Console** (Tools → NuGet Package Manager → Package Manager Console)
- Run:
```
Update-Database
```

**5. Run the application**
- Press `F5` or click the Run button

---

## 🔑 Default Login Credentials

| Username | Password | Role |
|----------|----------|------|
| admin | admin123 | Admin |

> ⚠️ Change the default password after first login for security.

---

## 🎨 UI Design

- **Color Theme:** Blue & White (clean medical aesthetic)
- **Style:** Flat & Minimal (modern)
- **Primary Color:** `#1A73E8`
- **Font:** Segoe UI

### Appointment Color Coding
| Color | Status |
|-------|--------|
| 🔵 Light Blue | Scheduled |
| 🟢 Light Green | Completed |
| 🔴 Light Coral | Cancelled |
| 🟡 Light Yellow | No-Show |

---

## 📁 Project Structure

```
MediTrack/
├── Data/
│   └── AppDbContext.cs
├── Forms/
│   ├── Auth/
│   │   └── LoginForm.cs
│   ├── Dashboard/
│   │   └── DashboardForm.cs
│   ├── MasterFile/
│   │   ├── PatientListForm.cs
│   │   ├── PatientForm.cs
│   │   ├── DoctorListForm.cs
│   │   ├── DoctorForm.cs
│   │   ├── UserListForm.cs
│   │   └── UserForm.cs
│   ├── Transactions/
│   │   ├── AppointmentListForm.cs
│   │   └── AppointmentForm.cs
│   └── Reports/
│       └── ReportForm.cs
├── Models/
│   ├── User.cs
│   ├── Patient.cs
│   ├── Doctor.cs
│   ├── Appointment.cs
│   └── Prescription.cs
├── Services/
│   ├── AuthService.cs
│   ├── PatientService.cs
│   ├── DoctorService.cs
│   └── AppointmentService.cs
├── Migrations/
└── MediTrack.csproj
```

---

## 📝 License

This project was developed as an academic requirement for the **ELNET (Enterprise .NET)** course.

© 2026 MediTrack — All Rights Reserved.
