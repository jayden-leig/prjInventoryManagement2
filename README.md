# 🏷️ Project: prjInventoryManagement

## 📘 Overview
This project demonstrates key C# programming concepts:
- **Custom Types (Classes)**
- **Extension Methods**
- **Anonymous Types using LINQ**
- **Pointer Types explanation**

---

## 🧱 Custom Type
The `Product` class defines four properties:
- ID
- Name
- Quantity
- Price

Each `Product` represents an item in inventory.

---

## 🧮 Extension Methods
Two extension methods were added for `List<Product>`:
1. **CalculateTotalValue()** — calculates total stock value using `Sum()`.
2. **LowStock(threshold)** — filters items with low quantities.

Reference: [Microsoft Docs - Extension Methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)

---
## ScreenShots
<img width="401" height="736" alt="Screenshot 2025-10-19 125658" src="https://github.com/user-attachments/assets/0bcc8478-7289-42d3-bcd4-7886add11144" />
<img width="1734" height="880" alt="Screenshot 2025-10-19 125713" src="https://github.com/user-attachments/assets/2eef9574-af28-4d2d-a772-5e81a0a8c7ee" />


## 🔍 Anonymous Types & LINQ
A LINQ query was used to select product names and prices into anonymous types:
```csharp
var result = from p in products
             select new { p.Name, p.Price };

