using System.Data.SqlClient;
using static ApiMTarefas.Data.TarefaContext;

namespace ApiMTarefas.Extersions
{
    public static class ServiceCollectionsExtensions
    {
        public static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
        {
           

            builder.Services.AddScoped<GetConnection>(sp =>
                        async () =>
                        {
                            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
                            var connection = new SqlConnection(connectionString);
                            await connection.OpenAsync();
                            return connection;
                        });

            return builder;
        }
    }
}
