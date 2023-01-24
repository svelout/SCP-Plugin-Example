using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

namespace ScpPlugin.Handlers
{
    class Player
    {
        public void OnLeft(LeftEventArgs ev)
        {
            string message = Plugin.Instance.Config.LeftMessage.Replace("{player}", ev.Player.Nickname);
            Map.Broadcast(6, message);
        }

        public void OnJoined(JoinedEventArgs ev)
        {
            string message = Plugin.Instance.Config.JoinedMessage.Replace("{player}", ev.Player.Nickname);
            Map.Broadcast(6, message);
        }
    }
}
