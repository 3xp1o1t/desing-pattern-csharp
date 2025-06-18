using Strategy.Example1;

Navigator navigator = new Navigator(new ShortestRouteStrategy());

Console.WriteLine("Ingrese la ruta que desea calcular:\n1- Corta \n2- Larga \n3- Evitar pista");
string choice = Console.ReadLine();

switch (choice)
{
  case "1":
    navigator.SetStrategy(new ShortestRouteStrategy());
    break;
  case "2":
    navigator.SetStrategy(new LargestRouteStrategy());
    break;
  case "3":
    navigator.SetStrategy(new AvoidHighwaysRouteStrategy());
    break;
  default:
    navigator.SetStrategy(new ShortestRouteStrategy());
    break;
}

Console.WriteLine(navigator.ExecuteStrategy("a", "b"));
