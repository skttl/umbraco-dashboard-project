using Our.Umbraco.DashIt.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Composing;

namespace Our.Umbraco.DashIt.Collections
{
    public class DashItWidgetCollectionBuilder : OrderedCollectionBuilderBase<DashItWidgetCollectionBuilder, DashItWidgetCollection, IDashItWidget>
    {
        protected override DashItWidgetCollectionBuilder This => this;
    }
}
