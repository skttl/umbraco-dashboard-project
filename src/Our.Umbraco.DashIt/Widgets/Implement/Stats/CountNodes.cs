using Our.Umbraco.DashIt.Widgets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Services;

namespace Our.Umbraco.DashIt.Widgets.Implement.Stats
{
    public class CountNodes : BaseStatWidget
    {
        private IDataTypeService _dataTypeService;

        public CountNodes(IDataTypeService dataTypeService)
        {
            _dataTypeService = dataTypeService;
        }

        public override Stat Data()
        {
            return new Stat()
            {
                Description = "Hi ho",
                Icon = new Icon("umb-content", "#fff", "f00"),
                Value = _dataTypeService.GetAll().Count().ToString(),
                Difference = "22",
                IsPositive = true,
                Links = new List<Link> { new Link("Google", "https://www.google.com", "_blank") }
            };
        }
    }
}
