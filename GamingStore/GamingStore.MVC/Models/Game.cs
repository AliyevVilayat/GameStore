namespace GamingStore.MVC.Models;

public class Game:AuditableEntity
{
    public string ImgPath { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string GameId { get; set; }
    
}
