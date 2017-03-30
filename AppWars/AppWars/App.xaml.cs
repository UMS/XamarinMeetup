using Xamarin.Forms;
using AppWars.Views;
using AppWars.ViewModels;
using System.Collections.Generic;
using AppWars.Models;

namespace AppWars
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			try
			{
				MainPage = new AppWarsPage();
			}
			catch (System.Exception ex)
			{
				var exeption = ex.Message;
			}

		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
	public static class ViewModelLocator
	{

		static MoviesPageViewModel moviesVM;

		public static MoviesPageViewModel MoviesPageViewModel
		=> moviesVM ?? (moviesVM = new MoviesPageViewModel(true));


	}
}
