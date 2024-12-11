using GamingStore.MVC.Models;
using GamingStore.MVC.Services;
using GamingStore.MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GamingStore.MVC.Controllers;

public class HomeController : Controller
{
    private readonly IGameService _gameService;
    public HomeController(IGameService gameService)
    {
        _gameService = gameService;
    }
    public async Task<IActionResult> Index()
    {
        List<Game> games = await _gameService.GetAllGamesAsync();
        HomeVM homeVM = new HomeVM()
        {
            Games = games
        };
        return View(homeVM);
    }

    public async Task<IActionResult> ProductDetail(int id)
    {
        Game game = await _gameService.GetGameByIdAsync(id);
        List<Game> games = await _gameService.GetAllGamesAsync();
        ProductDetailVM productDetailVM = new ProductDetailVM()
        {
            Games = games,
            Game = game
        };
        return View(productDetailVM);
    }


}
