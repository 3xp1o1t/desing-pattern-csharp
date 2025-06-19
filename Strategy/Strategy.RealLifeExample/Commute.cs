namespace Strategy.RealLifeExample;

public class Commute
{
    private ITransportModeStrategy _strategy;

    public Commute(ITransportModeStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetTransportModeStrategy(ITransportModeStrategy strategy)
    {
        _strategy = strategy;
    }

    public void GoToWork()
    {
        _strategy.GoToWork();
    }
}