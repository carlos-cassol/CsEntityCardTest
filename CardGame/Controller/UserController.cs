using CardGame.Model;
using CardGame.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CardGame.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IPlayerRepositorie _playerRepositorie;
        public UserController(IPlayerRepositorie playerRepositorie) 
        {
            _playerRepositorie = playerRepositorie;
        }

        [HttpGet]
        public async Task<ActionResult<List<PlayerModel>>> ListAllUsers()
        {
            List<PlayerModel> usuarios = await _playerRepositorie.GetAllPlayers();
            return Ok(usuarios);
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<List<PlayerModel>>> SearchById(int id)
        {
            PlayerModel usuarios = await _playerRepositorie.GetPlayerById(id);
            return Ok(usuarios);
        }

        [HttpPost]
        public async Task<ActionResult<PlayerModel>> Register([FromBody] PlayerModel playerModel)
        {
            PlayerModel player = await _playerRepositorie.AddPlayer(playerModel);
            return Ok(player);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PlayerModel>> Update([FromBody] PlayerModel playerModel, int id)
        {
            PlayerModel player = await _playerRepositorie.UpdatePlayer(playerModel, id);
            return Ok(player);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PlayerModel>> Delete([FromBody] int id)
        {
            bool deleted = await _playerRepositorie.RemovePlayer(id);
            return Ok(deleted);
        }
    }
}
