using Pidev.Data;
using Pidev.Data.EntityWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pidev.Service
{
    public class ExpenseFormService
    {
        private Context c;
        public ExpenseFormService()
        {
            this.c = new Context();

        }

        public void AddEform(Tr a)
        {
          
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9080/Pidev-web/");

            var r = client.PostAsJsonAsync<Tr>("api/ExpCreate/add", a).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode()).Result;





        }
        static List<Tr> GetEform()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9080/Pidev-web/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/ExpCreate/getEform").Result;
            Task<List<Tr>> product = null;
            if (response.IsSuccessStatusCode)
            {
                product = response.Content.ReadAsAsync<List<Tr>>();
            }
            return product.Result;
        }
    }
}

