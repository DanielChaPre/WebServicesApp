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

namespace WebServicesApp.Core.Modelo
{
    public class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string ocupacion { get; set; }
        public string imagen { get; set; }
        public string sexo { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
    }
}