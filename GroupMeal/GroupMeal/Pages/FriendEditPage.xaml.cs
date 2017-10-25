using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GroupMeal.Models;


namespace GroupMeal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FriendEditPage : ContentPage
	{
		public FriendEditPage (Friend friend)
		{
			InitializeComponent ();
		}
	}
}