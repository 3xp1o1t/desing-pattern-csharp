namespace Strategy.RealLifeExample;

public class CarStrategy : ITransportModeStrategy
{
    public void GoToWork()
    {
        Console.WriteLine($"Ir en Automovil, es comodo pero gasta gasolita!");
    }
}