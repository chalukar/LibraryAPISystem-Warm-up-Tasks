# Warm-Up Tasks – Library System (C# Console + Unit Tests)
**This repository contains a set of **warm-up exercises** designed to validate your coding fundamentals before starting the full Library API System project.**

## ✅ Tasks Included

### **1. Check if a Book ID is a Power of Two**
A simple utility method that determines whether a given integer is a power of 2.  
Useful for validating “special edition” or structured ID formats.

```
(n > 0) && (n & (n - 1)) == 0
```
### **2. Reverse a Book Title**
Reverses the characters in a given book title.
```
Example:
   "Moby Dick" → "kciD yboM"
```

### **3. Generate Book Title Replicas**
Repeats a given title N times without spaces.
```
("Read", 3) → "ReadReadRead"

```
### **4. List Odd-Numbered Book IDs**
Prints all odd numbers in a given range, simulating odd-numbered special collection IDs.
```
1 3 5 7 9 11 13 ...
````

## Unit Tests (xUnit)
A dedicated test project validates all warm-up logic using xUnit.

Tests include:

✔ Power-of-two validation

✔ Title reversal including null/empty

✔ Title replication for different counts

✔ Odd-number printing via output capture

Run tests via Visual Studio or CLI:
```
dotnet test
```
## Project Structure
```
WarmUpTasks/
│
├── WarmupTasks/
│   ├── Program.cs
│   └── Services/
│       └── WarmUpTaskService.cs
│
└── WarmUpTasks.Tests/
    ├── WarmUpTaskServiceTests.cs
```
## How to Run
**1. Clone Repository**
```
git clone https://github.com/yourusername/WarmupTasks.git
cd WarmupTasks
````

**2. Run the Console App**
```
dotnet run --project WarmupTasks
```
**3. Run Unit Tests**
```
dotnet test
```
