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

        public void AddEform()
        {
            Tr c = new Tr();
            c.justification = "aaaaaaa";
            c.amount = "200,00";
            c.description = "jjj";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9080/Pidev-web/");

        var r =client.PostAsJsonAsync<Tr>("api/ExpCreate/add", c).ContinueWith((postTask)=> postTask.Result.EnsureSuccessStatusCode()).Result;
           


            

        }
         static async Task<Tr>  GetEform()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9080/Pidev-web/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/ExpCreate/getEform").Result;
            Tr product = null;
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Tr>();
            }
            return product;
        }
        public async void aff()
        { await GetEform(); }
    } }
