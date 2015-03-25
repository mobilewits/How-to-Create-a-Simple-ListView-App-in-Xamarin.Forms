using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace ListViewCellXamarinForms
{
	public class App : Application
	{
		public App ()
		{
			List<string> list = new List<string> ();
			list.Add ("Apple");
			list.Add ("Mango");
			list.Add ("Banana");
			list.Add ("WaterMelon");
			list.Add ("Lemon");
			list.Add ("Graps");

			ListView listview=new ListView(){
				ItemsSource=list };
		
			// The root page of your application
			MainPage = new ContentPage 
			{
				Content = new StackLayout 
				{
					VerticalOptions = LayoutOptions.Center,
					Children = 
					{
				listview
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

