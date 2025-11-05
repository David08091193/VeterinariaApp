using Microsoft.Maui.Controls;
using VeterinariaApp.Views;


namespace VeterinariaApp.Views
{
    public partial class MenuPrincipalPage : ContentPage
    {
        public MenuPrincipalPage()
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
            await DisplayAlert("Próximamente", "La agenda de citas estará disponible en la siguiente fase.", "OK");
        }

        private async void OnHistorialMedicoClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Próximamente", "El historial médico estará disponible en la siguiente fase.", "OK");
        }

        private async void OnEntradaSalidaClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Próximamente", "El módulo de entrada/salida estará disponible en la siguiente fase.", "OK");
        }
    }
}
