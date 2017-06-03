using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroChat.Views;
using Xamarin.Forms;
using HeroChat.ViewModels;

namespace HeroChat
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }

        private async void SignInBtn_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Chat());
        }

        private async void SignUpBtn_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegistrationPage());
        }
    }
}
