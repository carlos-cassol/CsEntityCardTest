using CardGame.Model;

namespace CardGame.Repositories.Interfaces
{
    public interface IPlayerRepositorie
    {
        Task<List<PlayerModel>> GetAllPlayers();
        Task<PlayerModel> GetPlayerById(int id);
        Task<PlayerModel> AddPlayer(PlayerModel player);
        Task<PlayerModel> UpdatePlayer(PlayerModel player, int id);
        Task<bool> RemovePlayer(int id);
    }
}
