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
using System.Windows.Shapes;

namespace proyectoInterfazClima
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            string alumnoAprobado = mainWindow.alumnoAprobado;
            double media = mainWindow.media;

            if (!string.IsNullOrEmpty(alumnoAprobado))
            {
                alumnoFeliz.Content = "Eres muy grande " + alumnoAprobado;
                notaMedia.Content = $"Nota media: {media.ToString("0.00")}";
            }
            else
            {
                alumnoFeliz.Content = "El nombre del alumno no está disponible";
            }
        }

        private void Salida_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
