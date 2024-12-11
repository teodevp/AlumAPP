using Alum.Modelos; 
using Microsoft.Maui.Controls;
using System;

namespace AlumAPP.Vistas
{
    public partial class AgregarAlumno : ContentPage
    {
        public AgregarAlumno()
        {
            InitializeComponent(); 
        }

        private void OnAgregarAlumnoButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombreEntry.Text) || string.IsNullOrEmpty(emailEntry.Text) ||
                string.IsNullOrEmpty(edadEntry.Text) || string.IsNullOrEmpty(cursoEntry.Text))
            {
                DisplayAlert("Error", "Todos los campos deben ser llenados", "OK");
                return;
            }

            if (!int.TryParse(edadEntry.Text, out int edad))
            {
                DisplayAlert("Error", "La edad debe ser un número válido", "OK");
                return;
            }

            var nuevoAlumno = new Alumno
            {
                Nombre = nombreEntry.Text,
                Email = emailEntry.Text,
                Edad = edad, 
                Curso = cursoEntry.Text,
                Activo = activoSwitch.IsToggled  
            };

            nombreEntry.Text = string.Empty;
            emailEntry.Text = string.Empty;
            edadEntry.Text = string.Empty;
            cursoEntry.Text = string.Empty;
            activoSwitch.IsToggled = false;

            DisplayAlert("Éxito", "Alumno agregado correctamente", "OK");
        }
    }
}
