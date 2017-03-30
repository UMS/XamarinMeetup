using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AppWars.Models;
using Newtonsoft.Json;

namespace AppWars.Services
{
	public class SwapiService : ISwapiService
	{
		public string _baseUrl
		{
			get;
			set;
		}
		public SwapiService()
		{
			_baseUrl = "http://swapi.co/api/";
		}
		public async Task<PersonsResponse> GetPersons()
		{
			PersonsResponse response = new PersonsResponse();
			try
			{
				Debug.WriteLine("Get persons");
				var requestUrl = string.Format("{0}people/", _baseUrl);
				using (var client = new HttpClient())
				{
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
					var resultString = await client.GetStringAsync(requestUrl);
					response = JsonConvert.DeserializeObject<PersonsResponse>(resultString);
					return response;
				}
			}
			catch (Exception ex)
			{
				return null;
			}
			return response;
		}
		public async Task<FilmResponse> GetFilms()
		{
			FilmResponse response = new FilmResponse();
			try
			{
				Debug.WriteLine("Get films");
				var requestUrl = string.Format("{0}films/", _baseUrl);
				using (var client = new HttpClient())
				{
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
					var resultString = await client.GetStringAsync(requestUrl);
					response = JsonConvert.DeserializeObject<FilmResponse>(resultString);
					return response;
				}
			}
			catch (Exception ex)
			{
				return null;
			}
			return response;
		}
	}
}
