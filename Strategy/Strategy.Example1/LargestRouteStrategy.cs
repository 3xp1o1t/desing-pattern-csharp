namespace Strategy.Example1;

public class LargestRouteStrategy : IRouteStrategy
{
    public string CalculateRoute(string a, string b)
    {
        return $"La ruta mas larga a sido calculada.";
    }
}