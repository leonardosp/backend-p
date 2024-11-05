using Backend_p.Application.Object;

namespace Backend_p.Application.Services.Interfaces;

public interface IRequestPokemon
{
    Task<PokemonDto> GetPokemonByIdAsync(int Id);
    Task<PokemonDto> GetPokemonByNameAsync(string name);
    Task<PokemonsList> GetPokemonsByLimitAsync(int limit);
}
