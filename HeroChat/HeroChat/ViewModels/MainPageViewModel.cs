using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HeroChat.ViewModels
{
    class MainPageViewModel:BaseViewModel
    {
        public MainPageViewModel()
        {
               
        }

        Command _signInPressedCommand;
        public Command SignInPressedCommand
        {
            get { return _signInPressedCommand ?? (_signInPressedCommand = new Command(ExecuteSignInPressed)); }
        }

        private void ExecuteSignInPressed(object obj)
        {
            
        }
    }
}
