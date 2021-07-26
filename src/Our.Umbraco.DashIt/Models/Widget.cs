using Our.Umbraco.DashIt.Enums;
using Our.Umbraco.DashIt.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our.Umbraco.DashIt.Models
{
    public class Widget
    {
        public Guid Id { get; set; }
        public DashItWidgetSize Size { get; set; }
        public string View { get; set; }
        public int Weight { get; set; }
        public object Data { get; set; }

        public Widget(IDashItWidget widget)
        {
            Size = widget.Size();
            View = widget.View();
            Weight = widget.Weight();
            Data = widget.Data();
        }
    }
}
