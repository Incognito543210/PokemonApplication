using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PokemonApplication.Helpers;
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
            isStartButtonVisible = true;
            isImageVisible = false;
            isNextQuestionButtonVisible = false;
            isCheckAnswerButtonVisible = false;
            isAnswerEntryVisible = false;
            isResultLabelVisible = false;
        }

        [ObservableProperty]
        List<PokemonInList> pokemonsInList;

        [ObservableProperty]
        PokemonInList pokemon;

        [ObservableProperty]
        private bool isStartButtonVisible;
        [ObservableProperty]
        private bool isImageVisible;
        [ObservableProperty]
        private bool isNextQuestionButtonVisible;
        [ObservableProperty]
        private bool isCheckAnswerButtonVisible;
        [ObservableProperty]
        private bool isAnswerEntryVisible;
        [ObservableProperty]
        private bool isResultLabelVisible;

        [ObservableProperty]
        private string point_LabelText;
        [ObservableProperty]
        private string result_LabelText;
        [ObservableProperty]
        private string answerEntry;
        [ObservableProperty]
        private string entryPlaceholder;

        [ObservableProperty]
        private bool isCheckAnswerEnabled;

        private int questions;
        private int points;

        [RelayCommand]
        public void StartQuiz()
        {
            QuizStarted();
            NextQuestion();
        }

        [RelayCommand]
        public void CheckAnswer()
        {
            if (AnswerEntry == null)
                Result_LabelText = "You did not write the pokemon.";
            else if (AnswerEntry.Trim().ToLower() == Pokemon.Name.Trim().ToLower())
            {
                Result_LabelText = "Correct!";
                points++;
                IsCheckAnswerEnabled = false;
            }
            else
            {
                Result_LabelText = $"You are wrong. Try again.";
                questions++;
            }

            updatePoints();
        }

        private void updatePoints()
        {
            Point_LabelText = $"Score: {points}/{questions}";
        }

        [RelayCommand]
        public void NextQuestion()
        {
            RandomizeQuestions();
            updatePoints();
            IsCheckAnswerEnabled = true;
        }

        private void RandomizeQuestions()
        {
            Random rnd = new Random();
            Pokemon = PokemonsInList[rnd.Next(PokemonsInList.Count)];
        }
        private void QuizStarted()
        {
            questions = 0;
            points = 0;
            IsStartButtonVisible = false;
            IsImageVisible = true;
            IsNextQuestionButtonVisible = true;
            IsCheckAnswerButtonVisible = true;
            IsAnswerEntryVisible = true;
            IsResultLabelVisible = true;
            updatePoints();
        }
    }
}
