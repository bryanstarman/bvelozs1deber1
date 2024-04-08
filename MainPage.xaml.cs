namespace bvelozt1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {
           
            String nombre=txtNombre.Text;
            String apellido=txtApellido.Text;
            String edad=txtEdad.Text;
            double sueldo=Convert.ToDouble(txtSalario.Text);
            double iess = (sueldo * 9.45) / 100;
            DisplayAlert("Alerta", "Bienvenido \n" + nombre + " " + apellido + "\n" + "Edad: " + edad+"\nAporte IESS: "+iess,"Cerrar");
        }
    }
    }