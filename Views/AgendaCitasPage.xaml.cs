using Microsoft.Maui.Controls;
using System;
using VeterinariaApp.Models;
using VeterinariaApp.Views; // 👈 Asegúrate de tener esto para acceder a ListaCitasPage

namespace VeterinariaApp.Views
{
    public partial class AgendaCitasPage : ContentPage
    {
        public AgendaCitasPage()
        {
            InitializeComponent();
        }

        private async void OnGuardarCitaClicked(object sender, EventArgs e)
        {
            string nombreMascota = mascotaEntry.Text;
            DateTime fecha = fechaPicker.Date;
            TimeSpan hora = horaPicker.Time;
            string motivo = motivoEditor.Text;

            if (string.IsNullOrWhiteSpace(nombreMascota) || string.IsNullOrWhiteSpace(motivo))
            {
                await DisplayAlert("Campos incompletos", "Por favor llena todos los campos.", "OK");
                return;
            }

            var nuevaCita = new Cita
            {
                NombreMascota = nombreMascota,
                Fecha = fecha,
                Hora = hora,
                Motivo = motivo
            };

            await App.Database.GuardarCitaAsync(nuevaCita);

            await DisplayAlert("Cita guardada", "La cita ha sido registrada correctamente.", "OK");

            // 👇 En lugar de regresar al menú, vamos directo a la lista de citas
            await Navigation.PushAsync(new ListaCitasPage());
        }
    }
}
