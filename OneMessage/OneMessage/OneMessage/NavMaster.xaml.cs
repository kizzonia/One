
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

namespace OneMessage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavMaster : ContentPage
    {
        public ListView ListView => ListViewMenuItems;

        public NavMaster()
        {
            InitializeComponent();
            BindingContext = new NavMasterViewModel();
        }



        class NavMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<NavMenuItem> MenuItems { get; }
            public NavMasterViewModel()
            {
                MenuItems = new ObservableCollection<NavMenuItem>(new[]
                {
                    new NavMenuItem { Id = 0, Title = "Page 1" },
                    new NavMenuItem { Id = 1, Title = "Page 2" },
                    new NavMenuItem { Id = 2, Title = "Page 3" },
                    new NavMenuItem { Id = 3, Title = "Page 4" },
                    new NavMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }
    }
}
