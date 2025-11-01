# 📚 RosiesLibraryApp

**RosiesLibraryApp** is a desktop **Windows Forms (WinForms)** application built with **C# .NET** and **SQLite**.  
It provides both **Admin** and **User** dashboards to manage and interact with a library system.

---

## 🧭 Overview

- 👩‍💼 **Admin Dashboard** manage the library’s book database — add, update, search and delete books.  
- 👤 **User Dashboard** can browse available books, borrow them, and return them.  
- 💾 All data is stored locally in a lightweight **SQLite** database (`library.db`).

---

## ✨ Features

### 👩‍💼 Admin Dashboard
- ➕ Add new books with **Title**, **Author**, **ISBN**, **Year**, and **Copies**
- ✏️ Update existing book information
- 🗑️ Delete books from the collection
- 📦 Track multiple copies per book
- 📋 View all books in a sortable **DataGridView**

### 👤 User Dashboard
- 📚 Browse all available books
- 📖 Borrow books (reduces available copies)
- 🔁 Return borrowed books (increases available copies)

---

## 🧰 Technologies Used

- **C# (.NET 8.0 Windows Forms)**
- **SQLite** via `Microsoft.Data.Sqlite`
- **Visual Studio 2022** (recommended IDE)

---
Database Structure:
TABLE Books
| Column   | Type                        | Description             |
| -------- | --------------------------- | ----------------------- |
| `Id`     | INTEGER (PK, AUTOINCREMENT) | Unique ID for each book |
| `Title`  | TEXT                        | Title of the book       |
| `Author` | TEXT                        | Author name             |
| `ISBN`   | TEXT                        | ISBN number             |
| `Year`   | INTEGER                     | Publication year        |
| `Copies` | INTEGER                     | Total copies available  |

TABLE Users
| Column     | Type                        | Description              |
| ---------- | --------------------------- | ------------------------ |
| `Id`       | INTEGER (PK, AUTOINCREMENT) | Unique ID for each user  |
| `Username` | TEXT                        | User login name          |
| `Password` | TEXT                        | password                 |
| `Email`     | TEXT                       |  User Email              |

TABLE BorrowedBooks
| Column       | Type                        | Description                           |
| ------------ | --------------------------- | ------------------------------------- |
| `Id`         | INTEGER (PK, AUTOINCREMENT) | Unique record ID                      |
| `UserId`     | INTEGER                     | Linked to the user who borrowed       |
| `BookId`     | INTEGER                     | Linked to the borrowed book           |
| `BorrowDate` | TEXT                        | Date the book was borrowed            |
| `ReturnDate` | TEXT                        | Date the book was returned            |

## 🚀 Getting Started

### 1. Clone the repository
```bash
git clone https://github.com/yourusername/RosiesLibraryApp.git
cd RosiesLibraryApp


