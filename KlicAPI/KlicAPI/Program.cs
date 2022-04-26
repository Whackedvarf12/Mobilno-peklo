using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KlicAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
            Console.Read();
        }
        static async Task RunAsync()
        {
            HttpClient klient = new HttpClient();
            klient.BaseAddress = new Uri("http://localhost:63732/");
            klient.DefaultRequestHeaders.Accept.Clear();
            klient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage odg = await klient.GetAsync("Api/products/1");
            if (odg.IsSuccessStatusCode)
            {
                Product p = await odg.Content.ReadAsAsync<Product>();
                Console.WriteLine("Moj produkt"+p.Ime);
            }
        }
    }
}
