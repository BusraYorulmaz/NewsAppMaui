using NewsAppMaui.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAppMaui.Services
{
    public class ApiService
    {
        public async Task<Root> GetNews(string categoryName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?category=general&apikey=809b2f884c58bc0975df5148b5cd5428&lang=en&topic=sports" + categoryName.ToLower()); 
            //ToLower ->kategori ismimizi küçük harflere çevirecektir.

            return JsonConvert.DeserializeObject<Root>(response);

                
        }
    }
}
