using GamingStore.MVC.Models;

namespace GamingStore.MVC.ViewModels;

public class ProductDetailVM
{
    public Game Game { get; set; }
    public List<Game> Games { get; set; }
}
