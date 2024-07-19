using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao_2M_1S.Model;
using Microsoft.Extensions.DependencyInjection;

namespace Dao_2M_1S
{
    public static class Helper
    {
        public static IServiceCollection RegisterDAOs(this IServiceCollection services) =>
            services
                .AddScoped<IClientiDao, ClientiDao>()
                .AddScoped<IOrdiniDao, OrdiniDao>();
    }
}
