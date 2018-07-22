using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PCode.Api.Infrastructure;
using PCode.Api.Infrastructure.Repositories;
using PCode.Domain.Interfaces;
using PCode.Domain.Interfaces.Repositories;

namespace PCode.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            const string connection = @"data source=.\SQLEXPRESS; initial catalog=Pcode.Core; integrated security=SSPI";
            
            services.AddDbContext<MainDatabaseContext>(options => options.UseSqlServer(connection));

            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddAutoMapper();
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = 
                new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
