using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WebApplication_Middleware.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware
    {
        private readonly RequestDelegate _next;

        public Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            IConfiguration config = (IConfiguration)httpContext
                .RequestServices.GetService(typeof(IConfiguration));
            string mensagem = null;

            using (SqlConnection conexao = new SqlConnection(
                config.GetConnectionString("ExemploMiddleware")))
            {
                conexao.Open();

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText =
                    "SELECT TOP 1 Mensagem FROM dbo.Indisponibilidade " +
                    "WHERE @DataProcessamento BETWEEN InicioIndisponibilidade " +
                      "AND TerminoIndisponibilidade " +
                    "ORDER BY InicioIndisponibilidade";
                cmd.Parameters.Add("@DataProcessamento",
                    SqlDbType.DateTime).Value = DateTime.Now;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    mensagem = reader["Mensagem"].ToString();

                conexao.Close();
            }

            if (mensagem == null)
                await _next(httpContext);
            else
            {
                httpContext.Response.StatusCode = 403;
                await httpContext.Response.WriteAsync(
                    $"<h1>{mensagem}</h1>");
            }
        }
    
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware>();
        }
    }
}
