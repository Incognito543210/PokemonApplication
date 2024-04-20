using PokemonApplication.ViewModels;

namespace PokemonApplication.View;


public partial class OnePokemonPage : ContentPage
{
  
    public OnePokemonPage(OnePokemonInfoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}