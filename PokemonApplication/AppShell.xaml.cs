using PokemonApplication.View;

namespace PokemonApplication
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(OnePokemonPage), typeof(OnePokemonPage));
            Routing.RegisterRoute(nameof(CheckYourKnowledgePage), typeof(CheckYourKnowledgePage));

        }
    }
}
