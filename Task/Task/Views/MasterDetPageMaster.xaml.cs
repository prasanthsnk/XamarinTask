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

namespace Task
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetPageMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetPageMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetPageMenuItem> MenuItems { get; set; }
            
            public MasterDetPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetPageMenuItem>(new[]
                {
                    new MasterDetPageMenuItem { Id = 0, Title = "Page 1" }
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