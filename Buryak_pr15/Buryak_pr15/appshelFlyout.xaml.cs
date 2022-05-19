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

namespace Buryak_pr15
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class appshelFlyout : ContentPage
    {
        public ListView ListView;

        public appshelFlyout()
        {
            InitializeComponent();

            BindingContext = new appshelFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class appshelFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<appshelFlyoutMenuItem> MenuItems { get; set; }

            public appshelFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<appshelFlyoutMenuItem>(new[]
                {
                    new appshelFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new appshelFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new appshelFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new appshelFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new appshelFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}