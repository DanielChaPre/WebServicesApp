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
using WebServicesApp.Core.Datos;
using WebServicesApp.Core.Modelo;

namespace WebServicesApp.Core.Servicios
{
    public class ServicioPersona
    {
        private RepositorioPersona _repositorioPersona;
        public ServicioPersona()
        {
            _repositorioPersona = new RepositorioPersona();
        }
        public List<Persona> obtenerPersona()
        {
            return _repositorioPersona.obtenerPersona();
        }
        public Persona obtenerPersonaPorId(int id)
        {
            return _repositorioPersona.obtenerPersonaPorId(id);
        }
    }
}