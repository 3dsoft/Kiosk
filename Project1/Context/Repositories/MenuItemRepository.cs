using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Context.Repositories
{
    public class MenuItemRepository
    {
        public static List<MenuItem> GetAllItems()
        {
            var client = new RestClient("http://localhost:11799/");
            var request = new RestRequest("api/kiosk");
            var response = client.Get(request);
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {

                List<MenuItem> list = JsonConvert.DeserializeObject<List<MenuItem>>(response.Content);

                return list;
            }


            return null;
        }
    }
}
