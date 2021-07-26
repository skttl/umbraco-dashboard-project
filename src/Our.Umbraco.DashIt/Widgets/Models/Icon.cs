using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our.Umbraco.DashIt.Widgets.Models
{
    public class Icon
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Background { get; set; }

        public Icon()
        {

        }

        public Icon(string name, string? color, string? background)
        {
            Name = name;
            Color = color;
            Background = background;
        }
    }
}
