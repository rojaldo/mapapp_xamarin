using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            var map = new Map(
            MapSpan.FromCenterAndRadius(
                    new Position(40.9634332, -5.6542315), Distance.FromMiles(2.5)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
        }
	}
}
