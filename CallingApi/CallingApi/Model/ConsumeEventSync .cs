using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleEventManager
{
    public class ConsumeEventSync
    {
        public async Task<string> GetAllEventData() //Get All Events Records  
        {
            var EmpResponse = "";
            ConsumeEventSync v = new ConsumeEventSync();
            //using (var client = new WebClient()) //WebClient  
            //{
            //    var result = client.DownloadString("https://localhost:5001/api/Test"); //URI  
            //    Console.WriteLine( result);
            //}
            using (var client = new HttpClient())
            {
                string Baseurl = "https://localhost:5001/";
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/Test/PersonalDetails");
                if (Res.IsSuccessStatusCode)
                {
                    EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(EmpResponse);
                    PostMethod();
                }
                return "";
            }
            }

        public async Task<string> PostMethod()
        {
            using (var client1 = new HttpClient())
            {
                var Name = "Magesh";
                string Baseurl = "https://localhost:5001/";
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //HttpResponseMessage Res = await client.PostAsJsonAsync("api/Test", Name);
                HttpResponseMessage response = await client.PostAsync("api/Test/'"+ Name +"'", new StringContent("",Encoding.UTF8));
                if (response != null)
                {
                    Console.WriteLine("---------------------------------------------------");
                    var EmpResponse = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(EmpResponse);
                    //var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                   
                    
                }
                }
            return "";
        }
    }
}