# BeautyBuzz - Appointment Management App

**BeautyBuzz** is a Windows Forms desktop application for managing appointments at beauty salons. It was developed as a personal project to streamline the scheduling of services like haircuts, manicures, and pedicures.

---

## 📌 Description

The application allows users to schedule, view, and manage appointments. Services, times, and customer data are stored in a local database, which can be restored from a `.bacpac` file.

The interface is clean and intuitive, allowing quick access to the appointment calendar and service management.

---

## ✅ Features

- Add/edit/delete appointments
- Choose from a variety of beauty services
- Appointment calendar
- Client name and contact validation
- Notification and conflict warnings

---

## 🛠 Technologies Used

- C# (.NET Framework)
- Windows Forms
- Visual Studio
- SQL Server (bacpac restore)
- ADO.NET for database interaction

---

## 🗃 Database

The project uses a SQL Server database with the following `.bacpac` file for restoration:

```
Servicii_Beauty.bacpac
```

You can restore this in SQL Server Management Studio to get access to the appointment and service data.

---

## 🚀 How to Run

1. Open the `BeautyBuzz.sln` file using **Visual Studio**
2. Make sure your database is restored and update the `App.config` connection string if necessary
3. Run the application with `F5` or `Start Debugging`

---

## 📂 Project Structure

```
BeautyBuzz/
├── BeautyBuzz.sln         # Visual Studio solution file
├── BeautyBuzz/            # Main C# WinForms project
│   ├── Program.cs
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── App.config
│   └── ...
└── Servicii_Beauty.bacpac # SQL Server database export
```

---

## 👤 Author

**Belu Liviu**  
Faculty of Electrical Engineering and Computer Science  
Transilvania University of Brașov
