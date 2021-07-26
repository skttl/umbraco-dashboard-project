using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our.Umbraco.DashIt.Widgets.Models
{
    public class Stat
    {
        public string Description { get; set; }
        public Icon Icon { get; set; }
        public string Value { get; set; }
        public string Difference { get; set; }
        public bool IsPositive { get; set; }
        public List<Link> Links { get; set; }
    }
}
