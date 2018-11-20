using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using DIceOut201118.Annotations;
using DIceOut201118.View;

namespace DIceOut201118.ViewModel
{
    public class MenuViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<NavigationViewItemBase> NavigationItems { get; set; }
        private NavigationViewItem _selectedItem;

        public NavigationViewItem SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; }
        }


        public MenuViewModel()
        {
            NavigationItems = new ObservableCollection<NavigationViewItemBase>()
            {
                new NavigationViewItem()
                {
                    Content = "Main Page",
                    Icon = new SymbolIcon(Symbol.Home),
                    Tag = typeof(MainPage)
                }
            };

            SelectedItem = NavigationItems.First() as NavigationViewItem;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
