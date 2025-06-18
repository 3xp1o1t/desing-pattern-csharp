namespace Strategy.Example1;

public class AvoidHighwaysRouteStrategy : IRouteStrategy
{
    public string CalculateRoute(string a, string b)
    {
        return $"Ruta evitando autopistas calculada.";
    }
}