namespace GamingStore.MVC.Exceptions;

public class GameNotFoundException:Exception
{
    public GameNotFoundException():base("Game not found.")
    {
        
    }

    public GameNotFoundException(string message) : base(message)
    {

    }
}
