using MauiTutoriales.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialesMaui.Pages
{
    public class PrincipalViewModel
    {
        public ObservableCollection<Persona> Personas { get; set; }

        public Command ComandoBorrar { get; set; }
        public PrincipalViewModel()
        {
            Personas = new ObservableCollection<Persona>
            {
                new Persona{Nombre= "Ruben", Apellido="Rueda", Altura = 1.75f, Edad=33},
                new Persona{Nombre= "Alvaro", Apellido="Mantilla", Altura = 1.55f, Edad=39},
                new Persona{Nombre= "Erika", Apellido="Ramirez", Altura = 1.65f, Edad=30}

            };

            ComandoBorrar = new Command(() => Personas.Clear());
        }
    }
}
