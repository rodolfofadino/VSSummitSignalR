using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Owin;

namespace DemoDash
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }

    public class Venda : Hub
    {
        public void NovaVenda(string produto)
        {
            var connectId = Context.ConnectionId;

            Clients.AllExcept(connectId).AlertarNovaVenda(produto);
        }
    }
}
