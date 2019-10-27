using LivrariaDDD.Domain.Interfaces.Services.Livros;
using LivrariaDDD.Services.services;
using Microsoft.Extensions.DependencyInjection;

namespace LivrariaDDD.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependeciesService (IServiceCollection servicecollection)
        {
            servicecollection.AddTransient<ILivroService, LivroService> (); //AddTransient = para cada operação e injeção cria uma instância 
            //servicecollection.AddTransient<IAutorservice, IAutorservice>();
        }
    }
}