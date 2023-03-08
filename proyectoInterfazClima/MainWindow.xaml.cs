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
            //Window1 ventanaAlumno = new Window1();

       

        double primerExamen = double.Parse(PrimerExamen.Text);
            double segundoExamen = double.Parse(SegundoExamen.Text);
            double trabajoClase = double.Parse(TrabajoClase.Text);
            double asistencia = double.Parse(Asistencia.Text);

            media = (primerExamen * 0.35) + (trabajoClase * 0.2) + (asistencia * 0.1) + (segundoExamen * 0.35);

            //double media = (primerExamen * 0.35) + (trabajoClase * 0.2) + (asistencia * 0.1) + (segundoExamen * 0.35);
            if (string.IsNullOrEmpty(PrimerExamen.Text) || string.IsNullOrEmpty(SegundoExamen.Text) || string.IsNullOrEmpty(TrabajoClase.Text)
                || string.IsNullOrEmpty(Asistencia.Text) || string.IsNullOrEmpty(nombre.Text))
            {
                
                MessageBox.Show("Debes rellenar todos los cuadros de texto para poder continuar", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
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
            
            
            

            
        }

        private void botonSalir(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
