using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SEDC.PizzaApp.DataAccess;
using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.EntityRepositories;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Helpers
{
   public static class DIModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
                                                                    //"Server=.;Database=PizzaDb;Trusted_Connection=True"
            services.AddDbContext<PizzaDbContext>(x => x.UseSqlServer("Server=.\\SQLExpress;Database=PizzaDb;Trusted_Connection=True"));

            services.AddTransient<IRepository<User>, UserEntityRepository>();
            services.AddTransient<IRepository<Order>, OrderEntityRepository>();
            services.AddTransient<IRepository<Pizza>, PizzaEntityRepository>();
            services.AddTransient<IRepository<Feedback>, FeedbackEntityRepository>();

            return services;
        }
    }
}
