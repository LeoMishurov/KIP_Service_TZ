using KIP_Service_TZ.DataAccess;
using KIP_Service_TZ.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba1API.DataAccess
{
    public class DataAccessModule
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            // Получение строки подключения к бд из конфигурации 
            var connection = configuration.GetConnectionString("MyCon");
            // Настройка зависимости, добавляет при необходимости объект MyContext
            services.AddDbContext<MyContext>(options => options.UseNpgsql(connection));

            // Настройка зависимости DependencyInjection, добавляет объект Repository
            services.AddScoped<RepositoryUser>();
            services.AddScoped<RepositoryQuery>();
            
        }
    }
}
