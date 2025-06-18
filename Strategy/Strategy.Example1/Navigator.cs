namespace Strategy.Example1;

public class Navigator
{
    private IRouteStrategy _strategy;

    public Navigator(IRouteStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IRouteStrategy strategy)
    {
        _strategy = strategy;
    }

    public string ExecuteStrategy(string a, string b)
    {
        return _strategy.CalculateRoute(a, b);
    }
}