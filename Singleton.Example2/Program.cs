using Singleton.Example2;

MySingleton mySingleton = MySingleton.GetInstance();
Console.WriteLine($"Singleton ID: {mySingleton.Id}");

MySingleton mySingleton2 = MySingleton.GetInstance();
Console.WriteLine($"Singleton ID: {mySingleton2.Id}");

MySingleton mySingleton3 = MySingleton.GetInstance();
Console.WriteLine($"Singleton ID: {mySingleton3.Id}");