using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetPageDetail : ContentPage
    {
        public MasterDetPageDetail()
        {
            InitializeComponent();
            List<UserModel> userList = new List<UserModel>();
            userList.Add(new UserModel("Prasanth", "Developer"));
            userList.Add(new UserModel("Pandi", "Developer"));
            this.BindingContext = new ViewModels.UserViewModel(userList);
        }
        //async System.Threading.Tasks.Task OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        //{
        //    UserModel user = e.SelectedItem as UserModel;
        //    var detailPage = new Views.DetailPage();
        //    detailPage.BindingContext = user;
        //    await Navigation.PushAsync(detailPage);
        //}
    }
}