using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;
using Assignment_9.Services;

namespace Assignment_9 {
    public class Startup {

        public Startup(IHostingEnvironment env) { }

        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc();
            services.AddTransient<IGargoyleDatabase, GargoyleDatabase>();
            
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
