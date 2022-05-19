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
    public partial class HystoryPageFlyout : ContentPage
    {
        public ListView ListView;

        public HystoryPageFlyout()
        {
            InitializeComponent();

            BindingContext = new HystoryPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class HystoryPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HystoryPageFlyoutMenuItem> MenuItems { get; set; }

            public HystoryPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<HystoryPageFlyoutMenuItem>(new[]
                {
                    new HystoryPageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new HystoryPageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new HystoryPageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new HystoryPageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new HystoryPageFlyoutMenuItem { Id = 4, Title = "Page 5" },
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