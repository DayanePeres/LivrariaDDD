using LivrariaDDD.Data.Context;
using LivrariaDDD.Data.Repository;
using LivrariaDDD.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LivrariaDDD.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependeciesRepository (IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped (typeof (IRepository<>), typeof(BaseRepository<>)); //AddScoped = para banco usa-se scoped

               serviceCollection.AddDbContext<MyContext> (
                options => options.UseMySql("Server=localhost;database=dbLivraria;userid=root;password=root")
            );

        }
    }
}