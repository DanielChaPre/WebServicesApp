using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using WebServicesApp.Core.Servicios;
using Square.Picasso;

namespace WebServicesApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public ImageView imgvSexo;
        public TextView txtNombre, txtEdad, txtOcupacion, txtSexo, txtUsuario;
        ServicioPersona servicioPersona;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            inicializar();

            seleccionarPersona();
        }
       
        public void inicializar()
        {
            servicioPersona = new ServicioPersona();
            txtNombre = FindViewById<TextView>(Resource.Id.txtNombre);
            txtEdad = FindViewById<TextView>(Resource.Id.txtEdad);
            txtOcupacion = FindViewById<TextView>(Resource.Id.txtOcupacion);
            txtSexo = FindViewById<TextView>(Resource.Id.txtSexo);
            txtUsuario = FindViewById<TextView>(Resource.Id.txtUsuario);
            imgvSexo = FindViewById<ImageView>(Resource.Id.imgvSexo);
        }
        public void seleccionarPersona()
        {
            var persona = servicioPersona.obtenerPersonaPorId(1);
            txtNombre.Text = persona.nombre;
            txtEdad.Text = persona.edad.ToString();
            txtOcupacion.Text = persona.ocupacion;
            txtSexo.Text = persona.sexo;
            txtUsuario.Text = persona.usuario;

            var display = WindowManager.DefaultDisplay;
            Android.Graphics.Point point = new Android.Graphics.Point();
            display.GetSize(point);

            var imagenURL = string.Concat(ValuesService.ImagenBaseUrl, persona.imagen);

            Picasso.With(ApplicationContext)
                .Load(imagenURL)
                .Resize(point.X, 0)
                .Into(imgvSexo);
        }
        public void trabajarImagen()
        {
           
        }
        /*public string seleccionarImagen(string sexo)
        {
            if (sexo.Equals("M"))
            {
                 var icon = GetDrawable(Resource.Drawable.icon_man);
            }
            else if (sexo.Equals("F"))
            {
                var icon = GetDrawable(Resource.Drawable.icon_woman);
                return icon;
            }
            
        }*/
    }
}