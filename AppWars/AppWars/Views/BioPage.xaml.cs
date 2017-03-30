using System;
using System.Collections.Generic;
using AppWars.ViewModels;
using Xamarin.Forms;

namespace AppWars.Views
{
	public partial class BioPage : ContentPage
	{
		public BioPage()
		{
			InitializeComponent();
		}
		public BioPage(BioPageViewModel vm)
		{
			InitializeComponent();
			BindingContext = vm.Person;

		}
	}
}
