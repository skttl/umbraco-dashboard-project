using Our.Umbraco.DashIt.Enums;
using Our.Umbraco.DashIt.Interfaces;
using Our.Umbraco.DashIt.Widgets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our.Umbraco.DashIt.Widgets
{
    public class BaseStatWidget : IDashItWidget
    {
        public virtual DashItWidgetSize Size() => DashItWidgetSize.Small;
        public virtual string View() => "/App_Plugins/Our.Umbraco.DashIt/views/widgets/stat.html";
        public virtual int Weight() => 0;
        public virtual object Data() => throw new NotImplementedException();
    }
}
