using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CarpoolingApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public void OnbtnForgot(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ForgotPasswordPage());
        }
        public void OnbtnGo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Request());
        }
        public void OnbtnReg(object sender, EventArgs args)
        {
            Navigation.PushAsync(new User_Profile());
        }
    }
}
