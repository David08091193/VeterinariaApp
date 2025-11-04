using Microsoft.Maui.Controls;
using VeterinariaApp.Models;

namespace VeterinariaApp.Views
{
    public partial class ListaMascotasPage : ContentPage
    {
        public ListaMascotasPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var mascotas = await App.Database.ObtenerMascotasAsync();
            mascotasCollection.ItemsSource = mascotas;
        }
    }
}
