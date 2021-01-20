using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenIddcit.Api.Authentication
{
    public static class OpenIddictServer
    {
        public static void addOpenIddictServer(this IServiceCollection services, bool requireHttps)
        {
            services.AddOpenIddict()
            .AddServer(options =>
            {
                // criando o endpoint para requisitar o token do OpenIddict
                options.SetTokenEndpointUris("/api/connect/token");

                
                options.AllowPasswordFlow()
                    .AllowRefreshTokenFlow();

                //aceitando clientes anonimos (clientes que não enviam client_id)
                options.AcceptAnonymousClients();



            });    
        }
    }
}
