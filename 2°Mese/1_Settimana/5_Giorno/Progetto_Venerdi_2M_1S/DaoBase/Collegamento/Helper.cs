using Microsoft.Extensions.DependencyInjection;
using Prog_S1_V.Interfacce;
using Prog_S1_V.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_S1_V.Collegamento
{
    public static class Helper
    {
        public static IServiceCollection RegisterDAOs(this IServiceCollection services) =>
            services
                .AddScoped<IVerbaleDao, VerbaleDao>()
                .AddScoped<ITrasgressoreDao, TrasgressoreDao>()
                .AddScoped<TipoViolazioneDao>();
            
    }
}
