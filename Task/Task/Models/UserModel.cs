using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    class UserModel
    {
        public UserModel(string name, string details) {
            this.name = name;
            this.details = details;

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

    }
}
