using System;
using System.Collections.Generic;
using AppWars.Services;
using AppWars.Models;
using Xamarin.Forms;
using AppWars.ViewModels;

namespace AppWars.Views
{
	public partial class CharactersPage : ContentPage
	{
		public CharactersPage()
		{
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);
			BindingContext = new CharactersPageViewModel(this.Navigation);
		}
	}
}
