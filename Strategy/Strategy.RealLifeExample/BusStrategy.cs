namespace Strategy.RealLifeExample;

public class BusStrategy : ITransportModeStrategy
{
    public void GoToWork()
    {
        Console.WriteLine($"Autobus, es barato y tedioso a la vez");
    }
}