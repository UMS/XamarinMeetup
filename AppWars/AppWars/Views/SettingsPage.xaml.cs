using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppWars.Views
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage()
		{
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);
		}
	}
}
