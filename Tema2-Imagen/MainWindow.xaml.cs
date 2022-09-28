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

namespace Tema2_Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ajustaOpacidad(object sender, RoutedEventArgs e)
        {
            if(opacidadBaja.IsChecked == true)
            {
                imagen.Opacity = 0.3;
            }
            else if (opacidadMedia.IsChecked == true)
            {
                imagen.Opacity = 0.6;
            }
            else if (opcidadAlta.IsChecked == true)
            {
                imagen.Opacity = 1;
            }
        }

        private void AjusteImagen(object sender, RoutedEventArgs e)
        {
            if(ajusteFill.IsChecked == true)
            {
                imagen.Stretch = Stretch.Fill;
            }
            else if(ajusteUniform.IsChecked == true)
            {
                imagen.Stretch = Stretch.Uniform;
            }
            else if (ajusteUniformToFill.IsChecked == true)
            {
                imagen.Stretch = Stretch.UniformToFill;
            }
            else if (ajusteNone.IsChecked == true)
            {
                imagen.Stretch = Stretch.None;
            }
        }
    }
}
