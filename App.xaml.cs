using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using VeterinariaApp.Views;

namespace VeterinariaApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Establece la página principal como una NavigationPage que inicia en BienvenidaPage
        MainPage = new NavigationPage(new BienvenidaPage());
    }
}
