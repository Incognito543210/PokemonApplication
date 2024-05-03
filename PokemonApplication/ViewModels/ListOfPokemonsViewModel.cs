using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PokemonApplication.Interfaces;
using PokemonApplication.Models;
using PokemonApplication.Services;
using PokemonApplication.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PokemonApplication.ViewModels
{
    public partial class ListOfPokemonsViewModel : BaseViewModel
    {
        IPokemonApiService _pokemonApiService;

        public ObservableCollection<PokemonInList> PokemonsList { get; } = new();
        public List<PokemonInList> _fullPokemonsList = new List<PokemonInList>();

        public ListOfPokemonsViewModel(IPokemonApiService pokemonApiService)
        {
            Title = "Pokemon List";
            _pokemonApiService = pokemonApiService;
            GetListOfPokemons();
        }

        [ObservableProperty]
        string pokemonToSearch;

        [ObservableProperty]
        private string iconPokemon;

        [ObservableProperty]
        private string namePokemon;

        [ObservableProperty]
        private int hpPokemon;

        [ObservableProperty]
        private bool isErrorVisible;

        [ObservableProperty]
        private string errorMessage;


        public void ShowError(string errorMessage)
        {
            IsErrorVisible = true;
            ErrorMessage = errorMessage;
        }

        public void HideError()
        {
            IsErrorVisible = false;
            ErrorMessage = string.Empty;
        }

        [RelayCommand]
        private void SearchPokemonInformation(string name)
        {
            var pokemonApiResponse = _pokemonApiService.GetPokemonInformation(name);
            if (pokemonApiResponse != null)
            {
                NamePokemon = pokemonApiResponse.Name;
                HpPokemon = pokemonApiResponse.Weight;
                IconPokemon = pokemonApiResponse.Sprites.front_default;

            }
            else
            {
                ShowError("Nie udało się pobrać listy pokemonów");
            }
        }



        [RelayCommand]
        private async Task GetListOfPokemons()

        {
            var pokemonListApiResponse = await _pokemonApiService.GetListOfPokemons();

            if (pokemonListApiResponse != null)
            {
                foreach (var pokemon in pokemonListApiResponse.Results)
                {
                    SearchPokemonInformation(pokemon.Name);

                    PokemonInList pokemonIn = new PokemonInList(NamePokemon, IconPokemon);


                    _fullPokemonsList.Add(pokemonIn);
                }
                UpdateDisplayedPokemonsList();
            }
            else
            {
                ShowError("Nie udało się pobrać listy pokemonów");
            }

        }

        [RelayCommand]
        private void UpdateDisplayedPokemonsList()
        {
            PokemonsList.Clear();
            foreach (var pokemon in _fullPokemonsList)
            {
                PokemonsList.Add(pokemon);
            }
        }

        [RelayCommand]
        private void SearchPokemonList()
        {
            HideError();
            if (string.IsNullOrWhiteSpace(PokemonToSearch))
            {
                UpdateDisplayedPokemonsList();
            }
            else
            {

                // Filter the list based on the partial name
                var filteredPokemons = _fullPokemonsList.Where(p => p.Name.Contains(PokemonToSearch, StringComparison.OrdinalIgnoreCase)).ToList();
                PokemonsList.Clear();
                foreach (var pokemon in filteredPokemons)
                {
                    PokemonsList.Add(pokemon);
                }
            }
        }


        [RelayCommand]
        async Task Tap(PokemonInList pokemon)
        {
            HideError();
            PokemonApiResponse pokemonApiResponse = _pokemonApiService.GetPokemonInformation(pokemon.Name);

            if (pokemonApiResponse != null)
            {

                await Shell.Current.GoToAsync($"{nameof(OnePokemonPage)}", true, new Dictionary<string, object>
        {
            {"Pokemon", pokemonApiResponse }
        });

            }
            else
            {
                ShowError("Nie udało się pobrać informacji o pokemonie");
            }
        }

        [RelayCommand]
        async Task CheckYouKonwledge()
        {
            HideError();

            if (_fullPokemonsList != null)
            {
                await Shell.Current.GoToAsync($"{nameof(CheckYourKnowledgePage)}", true, new Dictionary<string, object>
            {
                {"PokemonsInList", _fullPokemonsList }
            });
            }
            else
            {
                ShowError("Brak listy pokemonów, z których możnaby przeprowadzić quiz");
            }
        }


    }
}
