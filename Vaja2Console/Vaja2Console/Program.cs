using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Vaja2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
            var e=Console.Read();

        }
        static async Task RunAsync()
        {
            HttpClient klient = new HttpClient();
            klient.BaseAddress = new Uri("http://localhost:65382/");
            klient.DefaultRequestHeaders.Accept.Clear();
            klient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage odg = await klient.GetAsync("api/Mentor");
            if (odg.IsSuccessStatusCode)
            {
                List<Mentor> m = await odg.Content.ReadAsAsync<List<Mentor>>();
                foreach(Mentor element in m){
                    Console.WriteLine(element.MenIme, element);

                }
            }
        }

    }
    }
    class Mentor
    {
        public int MenId { get; set; }
        public string MenIme { get; set; }
        public string MenPriimek { get; set; }
        public string MenVloga { get; set; }
        public string MenNaziv { get; set; }
        public string MenUstanova { get; set; }
        public string UserID { get; set; }
    }
