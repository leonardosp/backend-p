namespace Backend_p.Infra.POKECLIENT.Interface;

public interface IPokeClient
{
    Task<string> GetPokemonByIdAsync(int Id);
    Task<string> GetPokemonByNameAsync(string name);
    Task<string> GetPokemonsByLimitAsync(int limit);
}
