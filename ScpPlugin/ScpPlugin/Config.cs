using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Interfaces;

namespace ScpPlugin
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("Активируется когда кто то зайдет на север, {player} это имя игрока")]
        public string JoinedMessage { get; set; } = "{player} зашел на сервер";
        [Description("Активируется когда кто то выйдет из сервера, {player} это имя игрока")]
        public string LeftMessage { get; set; } = "{player} вышел из сервера";
        [Description("Активируется когда раунд начинается, {player} это имя игрока")]
        public string RoundStartMessage { get; set; } = "Готовьтесь к началу";
    }
}
