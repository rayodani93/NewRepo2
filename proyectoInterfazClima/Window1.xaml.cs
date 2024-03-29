﻿using System;
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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            string alumnoSuspenso = mainWindow.alumnoSuspenso;
            double media = mainWindow.media;

            if (!string.IsNullOrEmpty(alumnoSuspenso))
            {
                alumnoTriste.Content = "Espabila de una vez " + alumnoSuspenso;
                notaMedia.Content = $"Nota media: {media.ToString("0.00")}";
            }
            else
            {
                alumnoTriste.Content = "El nombre del alumno no está disponible";
            }
        }

        private void Salida_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
