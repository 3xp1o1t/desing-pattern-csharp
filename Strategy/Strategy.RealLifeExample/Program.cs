using Strategy.RealLifeExample;

var morningCommute = new Commute(new BikeStrategy());
var middayCommute = new Commute(new CarStrategy());
var eveningCommute = new Commute(new BusStrategy());

Console.Write($"Ingresa la hora de salida entre las 0 a 23 hrs:");
int hour = int.Parse(Console.ReadLine());

if (hour >= 7 && hour <= 9)
{
  Console.WriteLine($"Salir temprano es mejor en: ");
  morningCommute.GoToWork();
}
else if (hour >= 10 && hour <= 16)
{
  Console.WriteLine($"Salir por la tarde es mejor en: ");
  middayCommute.GoToWork();
}
else if (hour >= 17 && hour <= 19)
{
  Console.WriteLine($"Salir por la noche es mejor en: ");
  eveningCommute.GoToWork();
}
else
{
  Console.WriteLine($"Salir a esa hora es mejor en: ");
  morningCommute.GoToWork();
}
