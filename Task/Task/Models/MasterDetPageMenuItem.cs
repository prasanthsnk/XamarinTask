using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Views;

namespace Task
{

    public class MasterDetPageMenuItem
    {
        public MasterDetPageMenuItem(string type)
        {
            switch (type) {
                case "detail":
                    TargetType = typeof(MasterDetPageDetail);
                    break;
                case "about":
                    TargetType = typeof(AboutPage);
                    break;
                default:
                    TargetType = typeof(MasterDetPageDetail);
                    break;
            }
            
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}