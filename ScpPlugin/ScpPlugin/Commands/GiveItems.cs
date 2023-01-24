using System;
using CommandSystem;
using RemoteAdmin;

namespace ScpPlugin.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class GiveItems : ICommand
    {
        public string Command { get; } = "giveitem";

        public string[] Aliases { get; } = { "item" };

        public string Description => throw new NotImplementedException();

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is  PlayerCommandSender player)
            {
                response = $"Give item to {player.Nickname}";
                return false;
            }
            else
            {
                response = "World!";
                return true;
            }
        }
    }
}
