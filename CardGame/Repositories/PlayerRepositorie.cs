using CardGame.Data;
using CardGame.Model;
using CardGame.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CardGame.Repositories
{
    public class PlayerRepositorie : IPlayerRepositorie
    {

        private readonly CardGameDBContext _dbContext;
        public PlayerRepositorie(CardGameDBContext cardGameDBContext) 
        {
            _dbContext = cardGameDBContext;
        }
        public async Task<List<PlayerModel>> GetAllPlayers()
        {
            return await _dbContext.Player.ToListAsync();
        }

        public async Task<PlayerModel> GetPlayerById(int id)
        {
            return await _dbContext.Player.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<PlayerModel> AddPlayer(PlayerModel player)
        {
            await _dbContext.Player.AddAsync(player);
            await _dbContext.SaveChangesAsync();

            return player;
        }
        
        public async Task<PlayerModel> UpdatePlayer(PlayerModel player, int id)
        {
                PlayerModel playerById = await GetPlayerById(id);

                if(playerById == null)
                {
                    throw new Exception($"Usuário para o ID {id} não foi encontrado no banco de dados.");
                }
                playerById.Name = player.Name;
                playerById.Cash = player.Cash;

                _dbContext.Player.Update(playerById);
                await _dbContext.SaveChangesAsync();
                return playerById;
        }

        public async Task<bool> RemovePlayer(int id)
        {
                PlayerModel playerById = await GetPlayerById(id);

                if (playerById == null)
                {
                    throw new Exception($"Usuário para o ID {id} não foi encontrado no banco de dados.");
                }

                _dbContext.Player.Remove(playerById);
                await _dbContext.SaveChangesAsync();
                return true;
        }


    }
}
