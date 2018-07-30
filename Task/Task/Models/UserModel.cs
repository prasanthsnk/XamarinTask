using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Task.Models
{
    class UserModel
    {
        public UserModel(string name, string details) {
            this.name = name;
            this.details = details;
            DeleteClick = new Command(async () => {
               await App.Current.MainPage.Navigation.PopAsync();
            });

        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string details;

        public string Details
        {
            get { return details; }
            set { details = value; }
        }
        public ICommand DeleteClick { get; set; }
    }
}
