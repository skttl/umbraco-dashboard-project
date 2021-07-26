using Our.Umbraco.DashIt.Widgets.Implement.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace Our.Umbraco.DashIt.Collections
{
    public class DashItWidgetCollectionComposer : IUserComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.DashItWidgets().Append<CountNodes>();
        }
    }
}
