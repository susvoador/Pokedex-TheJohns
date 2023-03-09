using System.Text.Json;
using Pokedex.Models;

namespace Pokedex.Services;

public class PokeService : IPokeService
{
    private readonly IHttpContextAccessor _session;

    public PokeService(IHttpContextAccessor session)
    {
        _session = session;
    }
    public Pokemon GetPokemon(int Numero)

    {
        return null;
    }

    public List<Pokemon> GetPokemons()

    {
        return null;
    }

    public List<Tipo> GetTipos()


    {
        return null;
    }

    private void PopularSessao()
    {
        var tipos = JsonSerializer.Deserialize<List<Tipo>>(
            LerArquivo(@"Data\tipos.json")
        );
        var pokemons = JsonSerializer.Deserialize<List<Pokemon>>(
            LerArquivo(@"Data\pokemons.json")
            );
        if (string.IsNullOrEmpty(_session.HttpContext.Session.GetString("Tipos")))
        {
           _session.HttpContext.Session.SetString("Tipos", LerArquivo(@"Data\tipos.json"));
           _session.HttpContext.Session.SetString("Pokemons", LerArquivo(@"Data\pokemons.json"));
        }
    }

    private string LerArquivo(string nomeArquivo)
    {
        using (StreamReader leitor = new StreamReader(nomeArquivo))
        {
            string dados = leitor.ReadToEnd();
            return dados;
        }
    }



}

