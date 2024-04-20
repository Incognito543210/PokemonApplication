using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PokemonApplication.Models;
using PokemonApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApplication.ViewModels
{
    [QueryProperty("Pokemon", "Pokemon")]
    public partial class OnePokemonInfoViewModel: BaseViewModel
    {
      


        public OnePokemonInfoViewModel()
        {
            
        }

        [ObservableProperty]
        PokemonApiResponse pokemon;


      


     


    }
}
