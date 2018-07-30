using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{

    public class MasterDetPageMenuItem
    {
        public MasterDetPageMenuItem()
        {
            TargetType = typeof(MasterDetPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}