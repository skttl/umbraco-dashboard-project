using Microsoft.AspNetCore.Mvc;
using Our.Umbraco.DashIt.Collections;
using Our.Umbraco.DashIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Web.BackOffice.Controllers;
using Umbraco.Cms.Web.Common.Attributes;

namespace Our.Umbraco.DashIt.Controllers
{
    [PluginController("DashIt")]
    public class DashboardController : UmbracoAuthorizedJsonController
    {
        private readonly DashItWidgetCollection _widgets;

        public DashboardController(DashItWidgetCollection widgets)
        {
            _widgets = widgets;
        }

        [HttpGet]
        public dynamic GetWidgets()
        {
            return _widgets.Select(x => new Widget(x)).OrderBy(x => x.Weight);
        }
    }
}
