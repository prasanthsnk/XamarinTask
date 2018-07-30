using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Task.Common;

namespace Task.Models
{
    class MasterDetPageMasterViewModel :BaseViewModel
    {
        public ObservableCollection<MasterDetPageMenuItem> MenuItems { get; set; }

        public MasterDetPageMasterViewModel()
        {
            MenuItems = new ObservableCollection<MasterDetPageMenuItem>(new[]
            {
                    new MasterDetPageMenuItem("detail") { Id = 0, Title = "Details" },
                     new MasterDetPageMenuItem("about") { Id = 0, Title = "About" }
                });

        }
    }
}
