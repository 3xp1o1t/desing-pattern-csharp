namespace Strategy.RealLifeExample;

public class BikeStrategy : ITransportModeStrategy
{
    public void GoToWork()
    {
        Console.WriteLine($"Bicicleta modo de viaje, es sano y divertido");
    }
}