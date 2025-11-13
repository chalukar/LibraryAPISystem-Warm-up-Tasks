using WarmupTasks.Services;

var service = new WarmUpTaskService();

// 1. Power of Two
Console.WriteLine(" 1. Check if Book ID is a power of 2:");
Console.WriteLine($"2 - {service.IsPowerOfTwo(2)}");
Console.WriteLine($"8 - {service.IsPowerOfTwo(8)}");
Console.WriteLine($"10 - {service.IsPowerOfTwo(10)}");
Console.WriteLine($"24 - {service.IsPowerOfTwo(24)}");
Console.WriteLine();

// 2. Reverse a Book Title
// (Example: "Microservice in.NET Core" → "eroC TEN.ni ecivresorciM")
// (Example: "Moby Dick" → "kciD yboM")
Console.WriteLine("2. Check Reverse Book Title:");
Console.WriteLine(service.ReversBookTitle("Microservice in.NET Core"));
Console.WriteLine(service.ReversBookTitle("Moby Dick")); 
Console.WriteLine();

// 3. Generate Book Title Replicas
// (Example: ("Read", 4) → "ReadReadRead")
Console.WriteLine("3. Book Title Replicas:");
Console.WriteLine(service.RepeatBookTitle("Read", 4));
Console.WriteLine();

// 4. List Odd-Numbered IDs (0–100)
Console.WriteLine("4. Odd-numbered IDs:");
service.ListOddNumbersId(0, 100);
