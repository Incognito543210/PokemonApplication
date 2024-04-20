using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApplication.Models
{

    //Response api 
    public class PokemonsListApiResponse
    {
        public int Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public PokemonsListApiResponseResult[] Results { get; set; }
    }



    public class PokemonsListApiResponseResult
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
