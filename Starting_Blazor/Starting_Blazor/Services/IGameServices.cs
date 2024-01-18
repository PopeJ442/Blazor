using Starting_Blazor.Components.Games;

namespace Starting_Blazor.Services
{
    public interface IGameServices
    {
        Task<List<Game>> GetAllGames();
        
    }
}
