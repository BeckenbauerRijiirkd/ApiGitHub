using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ApiGitHubTest.Models
{
    public class Repos
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
