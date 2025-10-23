using Microsoft.VisualBasic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoBindingConObjetoDeNegocio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Crear una instancia del objeto de negocio Persona
            Persona usuario = new Persona("Juan", 20);

            /*
               Forma-1 para definir el DataContext por propiedades.
               nombreTextBox.DataContext = usuario;
               edadTextBox.DataContext = usuario;
            */

            /* 
               Forma-2 para definir el DataContext por PANEL.
            */
            datosStackPanel.DataContext = usuario;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Acceder al objeto de negocio a través del DataContext
            MessageBox.Show("Hola " + ((Persona)nombreTextBox.DataContext).Nombre 
                            + ", tienes " + ((Persona)edadTextBox.DataContext).Edad
                            + " años.", "Muestra los valores del OBJETO");

            MessageBox.Show("Ahora cambiamos nombre a 'Carlos' desde el código", "CAMBIO",MessageBoxButton.OK, MessageBoxImage.Information);
            // Modificar el valor de una propiedad del objeto de negocio
            ((Persona)nombreTextBox.DataContext).Nombre = "Carlos";

        }
    }
}