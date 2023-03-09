using Pokedex.Models;
namespace Pokedex.Services;

    public interface IPokeService
    {
        Pokemon GetPokemon(int numero); 

        List<Pokemon> GetPokemons(); 

        List<Tipo> GetTipos();
    }
