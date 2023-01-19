namespace WebApplication_Middleware
{
    public class IndisponibilidadePipeline
    {

        public void Configure(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseChecagemIndisponibilidade();
        }

    }
}
