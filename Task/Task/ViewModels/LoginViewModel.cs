using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Task.Common;
using Xamarin.Forms;

namespace Task.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        private string name;
        private string password;

        public LoginViewModel()
        {
            LoginClick = new Command(()=>{
                App.Current.MainPage = new NavigationPage(new MasterDetPage());
            
            });
        } 
        public string Name
        {
            get { return name; }
            set { name = value;
                NotifyPropertyChanged("Name");

            }
        }
        public string Password
        {
            get { return password; }
            set { password = value;
                NotifyPropertyChanged("Password");
            }
        }
        public ICommand LoginClick { get; set; }
    }
}
