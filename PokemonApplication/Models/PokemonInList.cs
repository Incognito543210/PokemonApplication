using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApplication.Models
{
    //Model for show pokemons in list in main page
    public class PokemonInList
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public PokemonInList(string name, string image)
        {


            Name = name;
            Image = image;

        }
    }
}
