using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using HelloCore.Models;


namespace HelloCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public async Task<IActionResult> GetAPIDAtaAsync()
        {
            var retValue= new List<string>();
            using(var client=new HttpClient())
            {
                 client.BaseAddress = new Uri("http://172.17.0.1:8019/");
                 client.DefaultRequestHeaders.Accept.Clear();
                 client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                 HttpResponseMessage response = await client.GetAsync("api/values")        ;
                 if(response.IsSuccessStatusCode)
                 {
                     retValue = await response.Content.ReadAsAsync<List<string>>();

                 }   

            }
            return View("ApiResult",retValue);
        }
    }
}
