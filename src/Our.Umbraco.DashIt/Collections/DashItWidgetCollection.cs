using Our.Umbraco.DashIt.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Composing;

namespace Our.Umbraco.DashIt.Collections
{
    public class DashItWidgetCollection : BuilderCollectionBase<IDashItWidget>
    {
        public DashItWidgetCollection(IEnumerable<IDashItWidget> widgets) : base(widgets)
        {

        }
    }
}
