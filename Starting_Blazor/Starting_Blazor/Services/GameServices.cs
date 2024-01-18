using Starting_Blazor.Components.Data;
using Starting_Blazor.Components.Games;
using System.Data.Entity;

namespace Starting_Blazor.Services
{
   
    public class GameServices : IGameServices
    {
        private readonly ApplicationDbContext _context;

        public GameServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Game>> GetAllGames()
        {
            
            var games = await _context.Game_List.ToListAsync();
            return games;   
        }

   
    }
}
