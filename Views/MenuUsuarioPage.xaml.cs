using Microsoft.Maui.Controls;

namespace VeterinariaApp.Views
{
    public partial class MenuUsuarioPage : ContentPage
    {
        public MenuUsuarioPage()
        {
            InitializeComponent();
        }

        private async void OnRegistrarMascotaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroMascotaPage());
        }

        private async void OnListaMascotasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaMascotasPage());
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
