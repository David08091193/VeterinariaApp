using Microsoft.Maui.Controls;

namespace VeterinariaApp.Views
{
    public partial class MenuVeterinarioPage : ContentPage
    {
        public MenuVeterinarioPage()
        {
            InitializeComponent();
        }

        private async void OnHistorialMedicoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistorialMedicoPage());
        }

        private async void OnAgendaCitasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AgendaCitasPage());
        }
        private async void OnCerrarSesionClicked(object sender, EventArgs e)
        {
            Preferences.Remove("Rol"); // Borra el rol guardado
            await Navigation.PopToRootAsync(); // Regresa al LoginPage
        }

    }
}
