using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Task.Models;
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
       
    }
}