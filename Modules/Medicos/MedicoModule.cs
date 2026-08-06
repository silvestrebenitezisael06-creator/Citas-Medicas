using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citas_Medicas.Modules.Medicos.Services;
using Citas_Medicas.Modules.Medicos.Repositories;

namespace Citas_Medicas.Modules.Medicos
{
    public static class MedicoModule
    {
        public static IServiceCollection AddMedicoModule(this IServiceCollection services)
        {
            services.AddScoped<MedicoRepository>();
            services.AddScoped<MedicoService>();

            return services;
        }
    
    }
}