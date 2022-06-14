using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Net.Http;

namespace Apisli
{
    class KlicServisa
    {
        public static async Task PopulateVsi(ObservableCollection<Slika> poti)
        {
            string url = "https://dog.ceo/api/breed/bullterrier/staffordshire/images";
            Odgovor p = new Odgovor();
            using (var klient=new HttpClient())
            {
                HttpResponseMessage sp = await klient.GetAsync(url);
                p = await sp.Content.ReadAsAsync<Odgovor>();
            }
            foreach (var x in p.message)
            {
                Slika s = new Slika();
                s.Pot = x;
                poti.Add(s);
            }
        }

    }
}
