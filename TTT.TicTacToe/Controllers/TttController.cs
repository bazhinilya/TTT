using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TTT.TicTacToe.Logic;
using TTT.TicTacToe.Models;
using TTT.TicTacToe.Models.Context;

namespace TTT.TicTacToe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TttController : Controller
    {
        private readonly TttLogic _logic;
        public TttController(TttContext context) => _logic = new TttLogic(context);

        [HttpGet]
        public async Task<IEnumerable<PlayingField>> Get() => await _logic.GetFields();

        [HttpPost]
        public async Task<PlayingField> Add(int id, bool value) => await _logic.AddField(id, value);

        [HttpDelete]
        public async Task<IEnumerable<PlayingField>> Clear() => await _logic.ClearFields();
    }
}
