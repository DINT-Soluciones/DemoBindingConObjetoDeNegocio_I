using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBindingConObjetoDeNegocio
{
    // Crear una clase de negocio que implemente INotifyPropertyChanged
    // de modo que notifique a la UI cuando una propiedad cambie.
    // Esto es esencial para que el data binding funcione correctamente.
    class Persona : INotifyPropertyChanged
    {
        // public string Nombre { get; set; }
        private string? _nombre;
        public string? Nombre
        {
            get { return _nombre; }
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    NotifyPropertyChanged("Nombre"); // Notificar el cambio de propiedad
                }
            }
        }

        // public int Edad { get; set; }
        private int _edad;
        public int Edad
        {
            get { return _edad; }
            set
            {
                if (_edad != value)
                {
                    _edad = value;
                    NotifyPropertyChanged("Edad"); // Notificar el cambio de propiedad
                }
            }
        }

        // Constructor vacío y con parámetros
        public Persona()
        {
            Nombre = "";
            Edad = 0;
        }
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Implementación de INotifyPropertyChanged
        // 
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
