using Microsoft.Extensions.DependencyInjection;
using Soluzione_S2_M2.Interfacce;
using Soluzione_S2_M2.Login;
using Soluzione_S2_M2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Connessione
{
    public static class Helper
    {
        public static IServiceCollection RegisterDAOs(this IServiceCollection services) =>
            services
                .AddScoped<IAuthService, AuthService>()
                .AddScoped<IServiceCamereDao, ServiceCamereDao>()
                .AddScoped<IServiceClientDao, ServiceClientiDao>();

    }
}
