using Backend_p.Infra.POKECLIENT.Interface;
using Backend_p.Infra.Utils;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace Backend_p.Infra.POKECLIENT;

public class PokeClient : IPokeClient
{
    private readonly HttpClient _httpClient;

    public PokeClient(HttpClient httpClient, IOptions<AppSettings> settings)
    {
        httpClient.BaseAddress = new Uri(settings.Value.ExternalRestApi);
        _httpClient = httpClient;
    }

    public async Task<string> GetPokemonByIdAsync(int Id)
    {
        var response = await _httpClient.GetAsync($"api/v2/pokemon/{Id}");

        var content = await response.Content.ReadAsStringAsync();

        return content;
    }

    public async Task<string> GetPokemonByNameAsync(string name)
    {
        var response = await _httpClient.GetAsync($"api/v2/pokemon/{name}");

        var content = await response.Content.ReadAsStringAsync();

        return content;
    }

    public async Task<string> GetPokemonsByLimitAsync(int limit)
    {
        var response = await _httpClient.GetAsync($"api/v2/pokemon?limit={limit}");

        var content = await response.Content.ReadAsStringAsync();

        return content;
    }
}
