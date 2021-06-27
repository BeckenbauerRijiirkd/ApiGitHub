using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGitHubTest.Models
{
    public interface IRepos<Repos>
    {
        [Headers("User-Agent:5fc568983d603df233a0136dd9162ddc206bcc22")]
        [Get("/users/BeckenbauerRijiirkd/repos")]
        Task<List<Repos>> ReadAll();


    }
}
