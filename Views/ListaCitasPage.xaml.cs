using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VeterinariaApp.Models;

namespace VeterinariaApp.Views
{
    public partial class ListaCitasPage : ContentPage
    {
        public ListaCitasPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await CargarCitas();
        }

        private async Task CargarCitas()
        {
            List<Cita> citas = await App.Database.ObtenerCitasAsync();
            citasCollectionView.ItemsSource = citas;
        }

        private async void OnEliminarCitaClicked(object sender, EventArgs e)
        {
            var boton = sender as Button;
            var citaSeleccionada = boton?.CommandParameter as Cita;

            if (citaSeleccionada == null)
                return;

            bool confirmar = await DisplayAlert("Confirmar", "¿Deseas eliminar esta cita?", "Sí", "No");
            if (confirmar)
            {
                await App.Database.EliminarCitaAsync(citaSeleccionada);
                await DisplayAlert("Cita eliminada", "La cita ha sido eliminada correctamente.", "OK");
                await CargarCitas(); // Recarga la lista
            }
        }
    }
}
