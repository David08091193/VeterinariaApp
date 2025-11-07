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
    }
}
