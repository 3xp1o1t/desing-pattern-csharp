namespace Strategy.Example1;

public class ShortestRouteStrategy : IRouteStrategy
{
  public string CalculateRoute(string a, string b)
  {
    return $"La ruta mas corta a sido calculada";
  }
}