using Alum.Modelos; 
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace AlumAPP.Vistas
{
    public partial class ListarAlumnos : ContentPage
    {
        public ObservableCollection<Alumno> Alumnos { get; set; }

        public ListarAlumnos()
        {
            InitializeComponent();

            Alumnos = new ObservableCollection<Alumno>
            {
                new Alumno { Nombre = "Juan Pérez", Email = "juan@example.com", Edad = 20, Curso = "1ro Medio", Activo = true },
                new Alumno { Nombre = "María Gómez", Email = "maria@example.com", Edad = 18, Curso = "4to Básico", Activo = false }
            };

            alumnosListView.ItemsSource = Alumnos; 
        }
        private void OnAlumnoSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Alumno alumno)
            {

            }
        }
    }
}
