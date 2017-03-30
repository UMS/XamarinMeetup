using System;
using AppWars.Models;
using AppWars.Services;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using AppWars.Views;

namespace AppWars.ViewModels
{
	public class MoviesPageViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private INavigation _navigation;
		private IList<Film> films;
		public IList<Film> Films
		{
			get { return films; }
			set
			{
				if (films != value)
				{
					films = value;
					OnPropertyChanged("Films");
				}
			}
		}
		public Film SelectedFilm
		{
			set
			{
				if (value != null)
				{
					// IoC omitted, we should really get someone else to 
					// create these objects for us.
					var viewModel = new FilmViewModel() { Film = value };
					var page = new FilmPage(viewModel);
					_navigation.PushAsync(page);
				}
			}
		}
		public MoviesPageViewModel(bool isDesignTime)
		{
			//_navigation = navigation;
			if (isDesignTime)
			{
				Films = new List<Film>();
				for (int i = 0; i < 10; i++)
				{
					Films.Add(new Film { Title = "MovieTitle " + i, EpisodeId = i, OpeningCrawl = "bla bla bla" });
				}
			}
		}
		public MoviesPageViewModel(INavigation navigation)
		{
			_navigation = navigation;
			if (Films == null)
				GetFilms();
		}
		async void GetFilms()
		{
			var swapi = new SwapiService();
			FilmResponse result = await swapi.GetFilms();
			if (result != null)
				Films = result.Films;

		}


		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
