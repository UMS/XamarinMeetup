using System;
using System.Collections.Generic;
using AppWars.Models;
using AppWars.ViewModels;
using Xamarin.Forms;

namespace AppWars.Views
{
	public partial class FilmPage : ContentPage
	{
		public FilmPage()
		{
			InitializeComponent();
		}

		public FilmPage(FilmViewModel vm)
		{
			InitializeComponent();
			BindingContext = vm.Film;

		}
	}
}
