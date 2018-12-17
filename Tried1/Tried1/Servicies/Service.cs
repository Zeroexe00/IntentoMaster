using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tried1.Models;

namespace Tried1.Servicies
{
    public class Service
    {
        private const string BASE = "https://miturno.azurewebsites.net";

        public static async Task<List<EmpaqueModel>> GetEmpaques(string path)
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync($"{BASE}/{path}");
                var json = await result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<EmpaqueModel>>(json);
            }
        }
        public static async Task<Models.EmpaqueModel> login (string email , string contra)
        {
            using(var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync($"{BASE}/{path}");
                var json = await result.Content.read 
            }
        }
    }
}
