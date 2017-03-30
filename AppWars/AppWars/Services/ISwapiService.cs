using System.Threading.Tasks;
using AppWars.Models;

namespace AppWars.Services
{
	public interface ISwapiService
	{
		 Task<PersonsResponse> GetPersons();
	}
}