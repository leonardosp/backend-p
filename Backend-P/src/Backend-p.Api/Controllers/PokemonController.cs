using Backend_p.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Formats.Asn1;
using System.Globalization;

namespace Backend_p.Api.Controllers
{
    [Route("Pokemon")]
    public class PokemonController : Controller
    {
        private readonly IRequestPokemon _requestPokemon;

        public PokemonController(IRequestPokemon requestPokemon)
        {
            _requestPokemon = requestPokemon;
        }

        [HttpGet("Id")]
        public async Task<IActionResult> Get(int Id)
        {
            var result = await _requestPokemon.GetPokemonByIdAsync(Id);    

            return Ok(result);
        }

        [HttpGet("Name")]
        public async Task<IActionResult> GetByName(string Name)
        {
            var result = await _requestPokemon.GetPokemonByNameAsync(Name);

            return Ok(result);
        }

        [HttpGet("Limit")]
        public async Task<IActionResult> GetAll(int Limit = 10)
        {
            var result = await _requestPokemon.GetPokemonsByLimitAsync(Limit);

            return Ok(result);
        }
    }
}
