using System;
using System;
using System.IO;
using System.Net;
using System.Net;
using System.Text;
using System.Net.Http;
using Wachira.Classes;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace WachiraJson
{
    class Program
    {
        static void Main(string[] args)
        {
            makeRequest();
        }

        static void makeRequest()
        {
            var TARGETURL = "https://jira.xpo.com/rest/agile/1.0/board/129/sprint?state=active";
            
            HttpClientHandler handler = new HttpClientHandler(){};

            Console.WriteLine("GET: + " + TARGETURL);

            HttpClient client = new HttpClient(handler);

            var byteArray = Encoding.ASCII.GetBytes("XLMBuildManager:password123");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            Task<HttpResponseMessage> response = client.GetAsync(TARGETURL);
            var _result = response.Result;

            if (_result != null && _result.IsSuccessStatusCode)
            {
                Console.WriteLine(_result.ToString());
            }

            Console.WriteLine("Response StatusCode: " + _result.StatusCode);

            var _resultString = _result.Content.ReadAsStringAsync();
            
            var _list = JsonConvert.DeserializeObject<Values>(_resultString.Result);
            
            var _t = JsonConvert.DeserializeObject<List<Values>>(_resultString.Result) as List<Values>;

        }
    }

}