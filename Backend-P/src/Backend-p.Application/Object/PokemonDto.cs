namespace Backend_p.Application.Object;

public class PokemonDto
{
    public double Id { get; set; }
    public double height { get; set; }
    public double weight { get; set; }
    public string name { get; set; }
    public double order { get; set; }
    public IEnumerable<Forms> Forms { get; set; }
    public IEnumerable<Abilities> Abilities { get; set; }
    public Cries Cries { get; set; }
    public IEnumerable<GameIndicies> Game_Indices { get; set; }
}
