﻿using sehirrehber.Data;

namespace sehirrehber
{
    public class startup
    {
        public class Startup
        {
            public IConfiguration Configuration { get; }
            public Startup(IConfiguration configuration)
            {
                this.Configuration = configuration;
            }

            // This method gets called by the runtime. Use this method to add serices to the container.
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddDbContext <DataContext>(x=> x.UseSqlServer (Configuration.GetConnectionString("DefaultConnection"))); //Sql server bulamadı 
                services.AddMvc();

            }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(WebApplication app, IWebHostEnvironment env)
            {

            }
        }
    }