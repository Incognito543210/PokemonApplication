using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PokemonApplication.Interfaces;
using PokemonApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApplication.ViewModels
{
    [QueryProperty("PokemonsInList", "PokemonsInList")]
    public partial class CheckYourKnowledgeViewModel : BaseViewModel
    {
        public CheckYourKnowledgeViewModel()
        {
        }

        [ObservableProperty]
        List<PokemonInList> pokemonsInList;

        [ObservableProperty]
        PokemonInList pokemon;


        [ObservableProperty]
        private string result_LabelText;
        [ObservableProperty]
        private string answerEntry;
        [ObservableProperty]
        private string entryPlaceholder;

        [RelayCommand]
        public void CheckAnswer()
        {
            if (answerEntry == pokemon.Name)
                result_LabelText = "Correct!";
            else
                result_LabelText = "You are wrong. Try again.";
        }

        [RelayCommand]
        public void NextQuestion()
        {
            result_LabelText = string.Empty;
            RandomizeQuestions();
        }

        private void RandomizeQuestions()
        {
            Random rnd = new Random();
            pokemon = pokemonsInList[rnd.Next(pokemonsInList.Count)];
        }
    }
}
