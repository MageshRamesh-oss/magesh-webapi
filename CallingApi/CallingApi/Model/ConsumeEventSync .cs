using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
namespace ConsoleEventManager
{
    public class ConsumeEventSync
    {
        public void GetAllEventData() //Get All Events Records  
        {
            using (var client = new WebClient()) //WebClient  
            {
                var result = client.DownloadString("https://localhost:5001/api/Test"); //URI  
                Console.WriteLine( result);
            }
        }
    }
}