using Our.Umbraco.DashIt.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our.Umbraco.DashIt.Interfaces
{
    public interface IDashItWidget
    {
        DashItWidgetSize Size();
        string View();
        int Weight();
        object Data();
    }
}
