using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CarpoolingApp
{
    public partial class Request : ContentPage
    {
        public Request()
        {
            InitializeComponent();
        }
        public void OnbtnRequest(object sender, EventArgs args)
        {
            Navigation.PushAsync(new RequestDrive ());
        }
        public void OnbtnShare(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ShareDrive());
        }

    }

}
