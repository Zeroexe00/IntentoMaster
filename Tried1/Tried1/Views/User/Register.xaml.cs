using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tried1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tried1.Views.User
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Register : ContentPage
	{
		public Register ()
		{
			InitializeComponent ();
            Sexo.ItemsSource =sex ;
		}

        string rut;
        string nombre;
        string apellido;
        DateTime fechanacimiento ;
        string email;
        string contraseña;
       
        string numphone;
        string region;
        string ciudad;
        int supermercado;

        List<sexo> sex = new List<sexo>();
        


        private void NuevoRegistro(object sender, EventArgs e)
        {
            EmpaqueModel emp = new EmpaqueModel();
            emp.Rut = Convert.ToInt32(Rut.Text.ToString());
            emp.FirstName = Nombre.Text;
            emp.LastName = Apellido.Text;
            emp.BirthDate = Dtp_fechanacimiento.Date;
            emp.Email = Email.Text;
            emp.Password = Contraseña.Text;
            emp.Gender = Convert.ToInt32(Sexo.ToString());
            emp.PhoneNumber = Convert.ToInt32(NumPhone.Text);
            emp.Address = Region.Text;
            if(Int32.TryParse(Supermercado.Text.ToString(), out supermercado))
            {
                emp.Supermarket = supermercado;
            }
            else
            {
                emp.Supermarket = 1;
            }
            



        }

        enum sexo:Int32
        {
            Hombre=0,Mujer,indefinido
        }

    }
}