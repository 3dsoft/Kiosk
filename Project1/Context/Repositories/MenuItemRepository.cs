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
        /// <summary>
        /// [TEST] 모든 메뉴 아이템을 가져온다.
        /// </summary>
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

        /// <summary>
        /// 선택한 메뉴에 맞는 하위 메뉴 아이템들을 가져온다.
        /// </summary>
        public static List<Project1.Models.MenuItem> GetAllMenuItem(int menuId)
        {
            var client = new RestClient("http://localhost:11799/");
            var request = new RestRequest("api/kiosk/menu/{id}");
            request.AddUrlSegment("id", menuId.ToString());

            var response = client.Get(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<Project1.Models.MenuItem>>(response.Content);
            }
            return null;
        }
    }
}
