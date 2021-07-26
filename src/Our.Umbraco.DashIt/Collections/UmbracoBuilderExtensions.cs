using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.DependencyInjection;

namespace Our.Umbraco.DashIt.Collections
{
    public static class UmbracoBuilderExtensions
    {
        public static DashItWidgetCollectionBuilder DashItWidgets(this IUmbracoBuilder builder)
            => builder.WithCollectionBuilder<DashItWidgetCollectionBuilder>();
    }
}
