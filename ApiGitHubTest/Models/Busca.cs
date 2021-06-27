using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGitHubTest.Models
{
    public class Busca
    {
        //[JsonProperty("total_count")]
        //public int total_count { get; set; }

        [JsonProperty("items")]
        public List<T> Items { get; set; }



    }
    public class T
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("updated_at")]
        public DateTime Updated_at { get; set; }

        [JsonProperty("owner")]
        public O Owner { get; set; }

        [JsonProperty("owner")]
        public L Contribuitors { get; set; }
    }

    public class O
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        

    }
    public class L
    {
        public List<string> Login { get; set; }
    }
}
