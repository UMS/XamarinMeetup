using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AppWars.Models
{
	public class PersonsResponse
	{
		[JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public IList<Person> Persons { get; set; }
    }
}
