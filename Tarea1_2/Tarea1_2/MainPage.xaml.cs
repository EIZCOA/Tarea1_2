using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            //Declarar nuestro Binding context

            var Contact = new Models.Contactos
            {
                nombre = edtnombre.Text.Trim(),
                apellido = edtapellido.Text.Trim(),
                edad =  Convert.ToInt32(edtedad.Text.Trim()),
                correo = edtemail.Text.Trim()

            };

            //cp: Content Page
            var cpContacto = new Contacto();

            cpContacto.BindingContext = Contact;

            await Navigation.PushModalAsync(cpContacto);
        }
    }
}
