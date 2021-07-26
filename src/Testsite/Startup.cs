using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Our.Umbraco.DashIt.Collections;
using Our.Umbraco.DashIt.Enums;
using Our.Umbraco.DashIt.Interfaces;
using Our.Umbraco.DashIt.Widgets;
using Our.Umbraco.DashIt.Widgets.Models;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Extensions;

namespace Testsite
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _config;

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="webHostEnvironment">The Web Host Environment</param>
        /// <param name="config">The Configuration</param>
        /// <remarks>
        /// Only a few services are possible to be injected here https://github.com/dotnet/aspnetcore/issues/9337
        /// </remarks>
        public Startup(IWebHostEnvironment webHostEnvironment, IConfiguration config)
        {
            _env = webHostEnvironment ?? throw new ArgumentNullException(nameof(webHostEnvironment));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }



        /// <summary>
        /// Configures the services
        /// </summary>
        /// <remarks>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        /// </remarks>
        public void ConfigureServices(IServiceCollection services)
        {
            var umbraco = services.AddUmbraco(_env, _config)
                .AddBackOffice()
                .AddWebsite()
                .AddComposers();

            umbraco.DashItWidgets().Append<RandomNumbersWidget>().Append<OtherRandomNumbersWidget>().Append<ThirdRandomNumbersWidget>().Append<RandomStatWidget>();

            umbraco.Build();

        }

        public class RandomNumbersWidget : IDashItWidget
        {
            public object Data()
            {
                Random rnd = new Random();
                var numbers = new List<int>();

                while (numbers.Count < 10)
                {
                    numbers.Add(rnd.Next(100, 999));
                }
                return numbers;
            }

            public DashItWidgetSize Size() => DashItWidgetSize.Large;
            public string View() => "/App_Plugins/MyOwnDashItWidgets/RandomNumbers.html";
            public int Weight() => 10;
        }

        public class OtherRandomNumbersWidget : IDashItWidget
        {
            public object Data()
            {
                Random rnd = new Random();
                var numbers = new List<int>();

                while (numbers.Count < 5)
                {
                    numbers.Add(rnd.Next(100, 999));
                }
                return numbers;
            }

            public DashItWidgetSize Size() => DashItWidgetSize.Medium;
            public string View() => "/App_Plugins/MyOwnDashItWidgets/RandomNumbers.html";
            public int Weight() => 5;
        }

        public class ThirdRandomNumbersWidget : IDashItWidget
        {
            public object Data()
            {
                Random rnd = new Random();
                var numbers = new List<int>();

                while (numbers.Count < 20)
                {
                    numbers.Add(rnd.Next(100, 999));
                }
                return numbers;
            }

            public DashItWidgetSize Size() => DashItWidgetSize.Full;
            public string View() => "/App_Plugins/MyOwnDashItWidgets/RandomNumbers.html";
            public int Weight() => 15;
        }

        public class RandomStatWidget : BaseStatWidget
        {
            public override object Data()
            {
                Random rnd = new Random();
                return new Stat()
                {
                    Description = "Random number",
                    Value = rnd.Next(100, 999).ToString()
                };
            }

            public override int Weight() => 15;
        }




        /// <summary>
        /// Configures the application
        /// </summary>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseUmbraco()
                .WithMiddleware(u =>
                {
                    u.WithBackOffice();
                    u.WithWebsite();
                })
                .WithEndpoints(u =>
                {
                    u.UseInstallerEndpoints();
                    u.UseBackOfficeEndpoints();
                    u.UseWebsiteEndpoints();
                });
        }
    }
}
