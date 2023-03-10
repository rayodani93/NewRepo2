using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace proyectoInterfazClima
{

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()


        {

            InitializeComponent();
            //string alumno = nombre.Text;
            ventana1.ControlBox = false;





        }
        public string alumnoAprobado { get; set; }

        public string alumnoSuspenso { get; set; }

        public double media { get; private set; }


        public bool ControlBox { get; private set; }


        private void botonCalcular(object sender, RoutedEventArgs e)
        {
            double primerExamen, segundoExamen, trabajoClase, asistencia;

            if (!double.TryParse(PrimerExamen.Text, out primerExamen) || primerExamen < 0 || primerExamen > 10 ||
                !double.TryParse(SegundoExamen.Text, out segundoExamen) || segundoExamen < 0 || segundoExamen > 10 ||
                !double.TryParse(TrabajoClase.Text, out trabajoClase) || trabajoClase < 0 || trabajoClase > 10 ||
                !double.TryParse(Asistencia.Text, out asistencia) || asistencia < 0 || asistencia > 10)
            {
                MessageBox.Show("Solo se permiten valores numéricos entre 0 y 10 en los cuadros de notas",
                                "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                // Vaciar el textbox que tiene un valor no numérico
                if (!double.TryParse(PrimerExamen.Text, out primerExamen) || primerExamen < 0 || primerExamen > 10)
                    PrimerExamen.Text = "";
                if (!double.TryParse(SegundoExamen.Text, out segundoExamen) || segundoExamen < 0 || segundoExamen > 10)
                    SegundoExamen.Text = "";
                if (!double.TryParse(TrabajoClase.Text, out trabajoClase) || trabajoClase < 0 || trabajoClase > 10)
                    TrabajoClase.Text = "";
                if (!double.TryParse(Asistencia.Text, out asistencia) || asistencia < 0 || asistencia > 10)
                    Asistencia.Text = "";

                return;
            }

            media = (primerExamen * 0.35) + (trabajoClase * 0.2) + (asistencia * 0.1) + (segundoExamen * 0.35);

            if (string.IsNullOrEmpty(nombre.Text))
            {
                MessageBox.Show("Debes rellenar todos los cuadros de texto para poder continuar", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (media >= 5)
            {
                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow.alumnoAprobado = nombre.Text;
                Window2 ventanaAprobado = new Window2();
                ventanaAprobado.Show();
            }
            else
            {
                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow.alumnoSuspenso = nombre.Text;
                Window1 ventanaSuspenso = new Window1();
                ventanaSuspenso.Show();
            }
        }

        private void botonSalir(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
