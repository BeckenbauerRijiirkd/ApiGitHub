using ApiGitHubTest.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiGitHubTest.Controllers
{
    public class UsersController : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            var loginClient = RestService.For<IUserApiService>("https://api.github.com");

            string loginInformado = "BeckenbauerRijiirkd";

            var result = await loginClient.GetAddressAsync(loginInformado);

            Console.WriteLine($"\nLogin:{result.Login}, \nId:{result.Id}, \nAvatar_url:{result.Avatar_url}");

            var repository = RestService.For<IRepos<Repos>>("https://api.github.com");
            var repostoryResult = await repository.ReadAll();

            List<string> parts = new List<string>();
            foreach (Repos element in repostoryResult)
            {
                Console.WriteLine($"{element.Name}");
                string teste = element.Name;
                parts.Add(teste);
            }
            result.Repositorios = parts;
            return View(result);
        }

    }
}
