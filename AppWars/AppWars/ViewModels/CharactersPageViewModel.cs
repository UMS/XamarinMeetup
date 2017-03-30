using System;
using System.Collections.Generic;
using PropertyChanged;
using AppWars.Models;
using AppWars.Services;
using Xamarin.Forms;
using AppWars.Views;

namespace AppWars.ViewModels
{
	[ImplementPropertyChanged]
	public class CharactersPageViewModel
	{
		private INavigation _navigation;
		public IList<Person> Persons
		{
			get;
			set;
		}
		public CharactersPageViewModel(INavigation navigation)
		{
			_navigation = navigation;
			if (Persons == null)
				GetPersons();
		}
		async void GetPersons()
		{
			var swapi = new SwapiService();
			PersonsResponse result = await swapi.GetPersons();
			if (result != null)
				Persons = result.Persons;

		}
		public Person SelectedPerson
		{
			set
			{
				if (value != null)
				{
					// IoC omitted, we should really get someone else to 
					// create these objects for us.
					var viewModel = new BioPageViewModel() { Person = value };
					var page = new BioPage(viewModel);
					_navigation.PushAsync(page);
				}
			}
		}
	}
}
