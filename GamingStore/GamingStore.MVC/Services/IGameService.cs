using GamingStore.MVC.Models;

namespace GamingStore.MVC.Services;

public interface IGameService
{
    Task<Game> GetGameByIdAsync(int id);
    Task<List<Game>> GetAllGamesAsync();
    Task AddGameAsync(Game game);
}
