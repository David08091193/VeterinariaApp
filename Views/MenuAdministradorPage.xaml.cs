using Microsoft.Maui.Controls;

namespace VeterinariaApp.Views
{
    public partial class MenuAdministradorPage : ContentPage
    {
        public MenuAdministradorPage()
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
        //CERRAR LA SESION
        private async void OnCerrarSesionClicked(object sender, EventArgs e)
        {
            Preferences.Remove("Rol"); // Borra el rol guardado
            await Navigation.PopToRootAsync(); // Regresa al LoginPage
        }

    }
}
