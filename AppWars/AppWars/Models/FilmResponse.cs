using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AppWars.Models
{

	public class FilmResponse
	{

		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("next")]
		public object Next { get; set; }

		[JsonProperty("previous")]
		public object Previous { get; set; }

		[JsonProperty("results")]
		public IList<Film> Films { get; set; }
	}
}
