using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGitHubTest.Models
{
    public interface IBusca
    {
        [Headers("User-Agent:5fc568983d603df233a0136dd9162ddc206bcc22")]
        [Get("/search/repositories?q={Pesquisa}")]
        Task<Busca> ReadAll(string Pesquisa);
    }
    public interface IBuscaPersonalizada
    {
        [Headers("User-Agent:5fc568983d603df233a0136dd9162ddc206bcc22")]
        [Get("/repos/{owner}/{repo}")]
        Task<T> ReadAll(string owner, string repo);
    } 
    public interface IBuscaColab
    {
        [Headers("User-Agent:5fc568983d603df233a0136dd9162ddc206bcc22")]
        [Get("/repos/{owner}/{repo}/contributors")]
        Task<List<O>> ReadAll(string owner, string repo);
    }
}
