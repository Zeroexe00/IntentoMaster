using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tried1.Models;
using Tried1.Servicies;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tried1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private void Ingresar(object sender, EventArgs e)
        {
            if (Txt_email.Text.Equals("") )
            {
                lbl_error_user.Text = "Error ingrese email";
                return;
            }else if (Txt_pass.Text.Equals("")) {
                lbl_error_pass.Text = "Error ingrese password";
                return;
            }
            string user = Txt_email.Text.ToString();
            string pass = Txt_pass.Text.ToString();
            string path = "api/Login?email="+user+"&contra="+pass;


           
           Service Serv = new Servicies.Service();

           Task<EmpaqueModel> Emp =  Service.Login(path);
            if(Emp!= null) { 
            bool ExisteReg =true;

            

                if(ExisteReg == true)
                {
                   
                    Navigation.PushAsync(new MainPage());
                    Application.Current.SavePropertiesAsync();
                }

            }
            else
            {
                lbl_error_user.Text = "Error : usuario no creado";
            }

            
        }

        private void Txt_email_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Txt_email == null)
            {
                
            }
        }

        private void Txt_pass_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}