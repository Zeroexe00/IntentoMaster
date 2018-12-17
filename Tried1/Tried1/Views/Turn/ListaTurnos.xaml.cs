using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tried1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tried1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaTurnos : ContentPage
	{
		public ListaTurnos ()
		{
			InitializeComponent ();
            LlenarTurnos();
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
        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsRefreshing = true;

                    await LlenarTurnos();

                    IsRefreshing = false;
                });
            }
        }
        private async Task LlenarTurnos()
        {
            HttpClient cliente = new HttpClient();
            string url = "https://miturno.azurewebsites.net/api/turn";
            var resultado = await cliente.GetAsync(url);
            var json = resultado.Content.ReadAsStringAsync().Result;

            List<Turno> turn = Turno.FromJson(json);

            ListadeTurnos.ItemsSource = turn ;
        }
	}
}