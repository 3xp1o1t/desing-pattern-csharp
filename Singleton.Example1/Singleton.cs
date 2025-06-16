namespace Singleton.Example1;

public class Singleton
{
    // 1 - Crear instancia estatica privada
    private static Singleton _instance;

    // 2 - Crear un constructor privado para que nadie genere instancias solo desde la clase.
    private Singleton()
    {
    }

    // 3 - Crear un metodo para obtener la instancia
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }

        return _instance;
    }
}