using Backend_p.Application.Object;
using Backend_p.Application.Services.Interfaces;
using Backend_p.Infra.POKECLIENT.Interface;
using System.Text.Json;

namespace Backend_p.Application.Services;

public class RequestPokemon : IRequestPokemon
{
    private readonly IPokeClient _pokeClient;
    private readonly JsonSerializerOptions Options;

    public RequestPokemon(IPokeClient pokeClient)
    {
        _pokeClient = pokeClient;

        Options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString
        };
    }

    public async Task<PokemonDto> GetPokemonByIdAsync(int Id)
    {
        var result = await _pokeClient.GetPokemonByIdAsync(Id);
        return JsonSerializer.Deserialize<PokemonDto>(result, Options);
    }

    public async Task<PokemonDto> GetPokemonByNameAsync(string name)
    {
        var result = await _pokeClient.GetPokemonByNameAsync(name);
        return JsonSerializer.Deserialize<PokemonDto>(result, Options);
    }

    public async Task<PokemonsList> GetPokemonsByLimitAsync(int limit)
    {
        var result = await _pokeClient.GetPokemonsByLimitAsync(limit);
        return JsonSerializer.Deserialize<PokemonsList>(result, Options);
    }
}
