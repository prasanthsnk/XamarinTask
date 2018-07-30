using System;
using System.Collections.Generic;
using System.Text;
using Task.Models;

namespace Task.ViewModels
{
    class UserViewModel: Common.BaseViewModel
    {
        private List<Models.UserModel> userList;

        public UserViewModel(List<UserModel> userList)
        {
            this.userList = userList;
        }

        public List<UserModel> UserList
        {
            get
            {
                return userList;
            }
            set
            {
                userList = value;
                NotifyPropertyChanged("UserList");
            }
        }

        UserModel _yourSelectedItem;
        public UserModel YourSelectedItem
        {
            get
            {
                return _yourSelectedItem;
            }

            set
            {
                _yourSelectedItem = value;
                UserModel user  = value as UserModel;
                var detailPage = new Views.DetailPage
                {
                    BindingContext = user
                };
                App.Current.MainPage.Navigation.PushAsync(detailPage);
                NotifyPropertyChanged("YourSelectedItem");

            }
        }
    }
}
