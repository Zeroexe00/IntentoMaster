using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tried1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tried1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MiPerfil : ContentPage
	{
		public MiPerfil ()
		{
			InitializeComponent ();
            Llenarview(emp);
		}

        public Servicies.Service ser = new Servicies.Service();
        
        public EmpaqueModel emp = new EmpaqueModel();
        
        private void Llenarview(EmpaqueModel emp)
        {
            emp= await ser.
            lbl_Usuarionombre.Text= emp.FirstName.ToString();
            lbl_Apellido.Text = emp.LastName.ToString();
            lbl_Rut.Text = emp.Rut.ToString();
            lbl_Supermercado.Text = emp.Supermarket.ToString();

        }

	}
}