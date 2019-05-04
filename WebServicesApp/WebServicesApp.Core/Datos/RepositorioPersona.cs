using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WebServicesApp.Core.Modelo;

namespace WebServicesApp.Core.Datos
{
    public class RepositorioPersona
    {
        private List<Persona> _personas;

        public RepositorioPersona()
        {
            _personas = new List<Persona>()
            {
                new Persona()
                {
                    id = 1,
                    nombre = "Daniel Chavez",
                    edad = 20,
                    ocupacion = "Programador Jr.",
                    imagen = "depositphotos_109949730-stock-illustration-flat-boy-vector-icon-man.jpg",
                    sexo = "M",
                    usuario = "dancha",
                    contrasenia = "1998"
                },
                new Persona()
                {
                    id = 2,
                    nombre = "Martin Chavez",
                    edad = 21,
                    ocupacion = "Programador Sr.",
                    imagen = "icon-man.png",
                    sexo = "M",
                    usuario = "danchapre",
                    contrasenia = "0000"
                }
            };
        }
        public List<Persona> obtenerPersona()
        {
            return _personas;
        }
        public Persona obtenerPersonaPorId(int id)
        {
            return _personas.FirstOrDefault(x => x.id == id);
        }
    }
}