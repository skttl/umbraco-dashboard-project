using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our.Umbraco.DashIt.Widgets.Models
{
    public class Link
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public string Target { get; set; }

        public Link()
        {

        }

        public Link(string text, string url, string? target)
        {
            Text = text;
            Url = url;
            Target = target;
        }
    }
}
