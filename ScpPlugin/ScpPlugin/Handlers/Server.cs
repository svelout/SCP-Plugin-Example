using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;

namespace ScpPlugin.Handlers
{
    class Server
    { 
        public void OnRoundStarted()
        {
            Map.Broadcast(6, Plugin.Instance.Config.RoundStartMessage);
        }
        public void OnWaitingForPlayers()
        {
            Log.Info("Ожидание игроков");
        }
    }
}
