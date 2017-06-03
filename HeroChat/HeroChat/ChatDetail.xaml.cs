using HeroChat.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HeroChat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatDetail : ContentPage
    {
        

        public ChatDetail()
        {
            
            InitializeComponent();
            BindingContext = new ChatDetailViewModel();
        }
    }
}