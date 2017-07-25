using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarpoolingApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class User_Profile : ContentPage
	{
		public User_Profile ()
		{
			InitializeComponent ();
		}
        public void OnbtnGo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}