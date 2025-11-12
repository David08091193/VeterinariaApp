using Microsoft.Maui.Controls;
using VeterinariaApp.Models;

namespace VeterinariaApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnIngresarClicked(object sender, EventArgs e)
        {
            var usuario = usuarioEntry.Text;
            var contraseña = contraseñaEntry.Text;

            var usuarioValido = await App.Database.ValidarUsuarioAsync(usuario, contraseña);

            if (usuarioValido != null)
            {
                await Navigation.PushAsync(new MenuPrincipalPage());
            }
            else
            {
                await DisplayAlert("Error", "Usuario o contraseña incorrectos.", "OK");
            }
        }

        private async void OnRegistrarseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroUsuarioPage());
        }
        //para que se borre el usaurio y la clave ingresada
        protected override void OnAppearing()
        {
            base.OnAppearing();

            usuarioEntry.Text = string.Empty;
            contraseñaEntry.Text = string.Empty;
        }


    }
}
