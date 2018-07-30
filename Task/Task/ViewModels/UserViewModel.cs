using System;
using System.Collections.Generic;
using System.Text;

namespace Task.ViewModels
{
    class UserViewModel: Common.BaseViewModel
    {
        private List<Models.UserModel> userList;

        public UserViewModel(List<Models.UserModel> userList)
        {
            this.userList = userList;
        }

        public List<Models.UserModel> UserList
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
    }
}
