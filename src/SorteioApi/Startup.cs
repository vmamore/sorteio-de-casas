using Application.CasosDeUso.Cadastros;
using Application.CasosDeUso.CalculoDePontos;
using Data;
using Data.Factories;
using Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.CalculadoraDePontos.Interfaces;
using Sorteio.Domain.Criterios.Interfaces;
using Sorteio.Domain.Familias.Interfaces;

namespace SorteioApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var connectionString = Configuration.GetConnectionString("MyConnectionString");

            services.AddDbContext<SorteioContext>(options =>
            {
                options.UseSqlServer(connectionString);
            }); 
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sorteio API", Version = "v1" });
            });

            services.AddScoped<IFamiliaRepository, FamiliaRepository>();
            services.AddScoped<IResultadoDaAvaliacaoDosCriteriosRepository, ResultadoDaAvaliacaoDosCriteriosRepository>();
            services.AddScoped<IFamiliaFactory, FamiliaFactory>();
            services.AddScoped<IAvaliacaoDeCriterios, AvaliacaoDeCriterios>();
            services.AddScoped(typeof(CadastroDeFamilia));
            services.AddScoped(typeof(CalculoDePontosDosCriteriosAtendidos));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sorteio API V1");
            });
        }
    }
}
