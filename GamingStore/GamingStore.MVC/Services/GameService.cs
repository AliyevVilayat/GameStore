using GamingStore.MVC.Contexts;
using GamingStore.MVC.Exceptions;
using GamingStore.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace GamingStore.MVC.Services;

public class GameService : IGameService
{
    private readonly GamingStoreDbContext _context;

    public GameService(GamingStoreDbContext context)
    {
        _context = context;
    }

    public async Task AddGameAsync(Game game)
    {
        await _context.Games.AddAsync(game);
        await _context.SaveChangesAsync();
    }

    public async Task<Game> GetGameByIdAsync(int id)
    {
        Game? game = await _context.Games.FindAsync(id);
        if (game is null) throw new GameNotFoundException();
        return game;
    }
    public async Task<List<Game>> GetAllGamesAsync()
    {
        List<Game> games = await _context.Games.ToListAsync();
        return games;
    }

}
