namespace GamingStore.MVC.Helpers;

public class Configurations
{

    public static string GetConnectionStr()
    {
        ConfigurationManager _configurationManager = new ConfigurationManager();

        _configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory()));
        _configurationManager.AddJsonFile("appsettings.json");

        string connectionStr = _configurationManager.GetConnectionString("PC")?? throw new Exception("Connection Str is null");
        return connectionStr;
    }
}
