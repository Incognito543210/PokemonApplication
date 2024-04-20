using PokemonApplication.ViewModels;

namespace PokemonApplication
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(ListOfPokemonsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext=viewModel;
        }

       
    }

}
