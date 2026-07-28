using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citas_Medicas.Modules.Citas.Services;
using Citas_Medicas.Modules.Citas;
namespace Citas_Medicas.Modules.Citas
{
    public static class CitasModule
    {
        public static IServiceCollection AddCitasModule(this IServiceCollection services)
        {
            services.AddSingleton<CitaService>();
            return services;
        }
    }
}