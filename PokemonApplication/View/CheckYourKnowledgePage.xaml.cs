using PokemonApplication.ViewModels;

namespace PokemonApplication.View;

public partial class CheckYourKnowledgePage : ContentPage
{
	public CheckYourKnowledgePage(CheckYourKnowledgeViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

	}
}