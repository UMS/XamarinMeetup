using System;
using System.Collections.Generic;
using AppWars.Models;
using AppWars.Services;
using Xamarin.Forms;
using AppWars.ViewModels;

namespace AppWars.Views
{
	public partial class MoviesPage : ContentPage
	{
		
		public MoviesPage()
		{
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);
			BindingContext = new MoviesPageViewModel(this.Navigation);

			//BindingContext = new MoviesPageViewModel(true);
		}

	}
}
