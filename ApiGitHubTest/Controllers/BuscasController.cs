using ApiGitHubTest.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGitHubTest.Controllers
{
    public class BuscasController : Controller
    {

        public async Task<ActionResult> IndexAsync(string Pesquisa = null)
        {

            List<T> parts = new List<T>();
            if (Pesquisa == null)

            {

                return View(parts);
            }
            else
            {
                var loginClient = RestService.For<IBusca>("https://api.github.com");

                var result = await loginClient.ReadAll(Pesquisa);
                T aux = new T();


                for (int i = 0; i < result.Items.Count; i++)
                {
                    aux = result.Items[i];
                    parts.Add(aux);

                }

                return View(parts);
            }

        }
        public async Task<ActionResult> Details(List<string> entrada)
        {
            T parts = new T();
            var loginClient = RestService.For<IBuscaPersonalizada>("https://api.github.com");

            var result = await loginClient.ReadAll(entrada[1],entrada[0]);
            T aux = new T();



            
                aux = result;
                parts = aux;
                if(entrada[0] == parts.Name) { 
                var loginColab = RestService.For<IBuscaColab>("https://api.github.com");

                var resultColab = await loginColab.ReadAll(parts.Owner.Login, parts.Name);

                L tt = new L();
                List<string> ss = new List<string>();

                for (int j = 0; j < resultColab.Count; j++)
                {
                    ss.Add(resultColab[j].Login);
                }
                tt.Login = ss;
                parts.Contribuitors = tt;
                    return View(parts);
                
                
            }
            return View(parts);
        }

    }
}

