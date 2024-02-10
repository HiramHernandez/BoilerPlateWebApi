namespace BoilerPlateWebApi
{
    public static class IOC
    {
        public static void DependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            //Agregar aqui las depencias que se van a inyectar: contexto de entityframework,
            //repositorios, servicios, contratos, instancia de automapper, etc.

        }
    }
}
