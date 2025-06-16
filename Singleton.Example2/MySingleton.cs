namespace Singleton.Example2;

public class MySingleton
{
    private static MySingleton? _instance;
    public Guid Id { get; private set; }

    private MySingleton()
    {
        Id = Guid.NewGuid();
    }

    public static MySingleton GetInstance()
    {
        if (_instance is null)
        {
            _instance = new MySingleton();
        }
        return _instance;
    }
}