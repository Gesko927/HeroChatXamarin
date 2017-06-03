using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HeroChat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatMaster : ContentPage
    {
        public ListView ListView => ListViewMenuItems;

        public ChatMaster()
        {
            InitializeComponent();
            BindingContext = new ChatMasterViewModel();
        }

        class ChatMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ChatMenuItem> MenuItems { get; }
            public ChatMasterViewModel()
            {
                MenuItems = new ObservableCollection<ChatMenuItem>(new[]
                {
                    new ChatMenuItem { Id = 0, Title = "Page 1" },
                    new ChatMenuItem { Id = 1, Title = "Page 2" },
                    new ChatMenuItem { Id = 2, Title = "Page 3" },
                    new ChatMenuItem { Id = 3, Title = "Page 4" },
                    new ChatMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            #endregion
        }
    }
}