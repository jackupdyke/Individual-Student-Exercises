﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PetInfoServer.DAL;
using PetInfoServer.DAL.Interfaces;
using PetInfoServer.Security;

namespace PetInfoServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // added for dependency injection
            string connectionString = Configuration.GetConnectionString("pet-info");

            services.AddSingleton<ITokenGenerator>(tk => new JwtGenerator(Configuration["JwtSecret"]));
            services.AddSingleton<IPasswordHasher>(ph => new PasswordHasher());

            services.AddTransient<IPetDAO>(m => new PetDAO(connectionString));
            services.AddTransient<IUserDAO>(m => new UserDAO(connectionString));
            services.AddTransient<IOwnerDAO>(m => new OwnerDAO(connectionString));
            services.AddTransient<IActivityDAO>(m => new ActivityDAO(connectionString));

            //end of addition

            services.AddMvc(option => option.EnableEndpointRouting = false)
               .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            // Add CORS policy allowing any origin
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

            // configure jwt authentication
            var key = Encoding.ASCII.GetBytes(Configuration["JwtSecret"]);
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap[JwtRegisteredClaimNames.Sub] = "sub";
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    NameClaimType = "name"
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
