using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tried1.Models;
using Tried1.Servicies;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tried1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Usuarios : ContentPage
	{
		public Usuarios ()
		{
			InitializeComponent ();
            LlenarUsuarios();

		}

        private bool _isRefreshing = false;

        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        private async void LlenarUsuarios()
        {
            
                List<EmpaqueModel> empaques = await Service.GetEmpaques("api/user");

                ListaDeUsuarios.ItemsSource = empaques;


            
        }
	}
}