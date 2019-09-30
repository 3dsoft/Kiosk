﻿using Newtonsoft.Json;
using Project1.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Context.Repositories
{
    public class ReceiptRepository
    {
        /// <summary>
        /// 결제 버튼을 클릭하면 결제 내용을 POST 형식으로 전송한다.
        /// </summary>
        public static bool SendPayment(Payment payment)
        {
            var client = new RestClient("http://localhost:11799");
            var request = new RestRequest("api/kiosk/payment");
            //request.AddJsonBody(JsonConvert.SerializeObject(payment, Formatting.Indented));
            request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(payment), ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            var res = client.Post(request);

            if (res.StatusCode == System.Net.HttpStatusCode.OK) return true;
            return false;
        }

        //public static List<MenuItem> GetAllItems()
        //{
        //    var client = new RestClient("http://localhost:11799/");
        //    var request = new RestRequest("api/kiosk");
        //    var response = client.Get(request);
        //    if (response.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        List<MenuItem> list = JsonConvert.DeserializeObject<List<MenuItem>>(response.Content);

        //        return list;
        //    }
        //    return null;
        //}

        //public static List<Project1.Models.MenuItem> GetAllMenuItem(int menuId)
        //{
        //    var client = new RestClient("http://localhost:11799/");
        //    var request = new RestRequest("api/kiosk/menu/{id}");
        //    request.AddUrlSegment("id", menuId.ToString());

        //    var response = client.Get(request);
        //    if (response.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        return JsonConvert.DeserializeObject<List<Project1.Models.MenuItem>>(response.Content);
        //    }
        //    return null;
        //}
    }
}
