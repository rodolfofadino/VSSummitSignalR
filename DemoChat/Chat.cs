using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace DemoChat
{
    public class Chat : Hub
    {
        public void EnviarMensagem(string mensagem, string nome)
        {
            Clients.All.TransmitirMensagem(mensagem, nome);
        }
    }
}
