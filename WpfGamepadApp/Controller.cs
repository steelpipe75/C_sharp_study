using Nefarius.ViGEm.Client;
using Nefarius.ViGEm.Client.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfGamepadApp
{
    internal class Controller
    {
        private IXbox360Controller controller;

        public Controller()
        {
            var client = new ViGEmClient();
            controller = client.CreateXbox360Controller();
        }

        public void Start()
        {
            controller.Connect();
        }

        public void Stop()
        {
            controller.Disconnect();
        }
    }
}
