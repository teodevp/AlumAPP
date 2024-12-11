using AlumAPP.Vistas;

namespace AlumAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
            MainPage = new ListarAlumnos();
        }
    }
}
