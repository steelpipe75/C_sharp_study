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
        private bool continue_flag;
        private Task procTask;

        public Controller()
        {
            var client = new ViGEmClient();
            controller = client.CreateXbox360Controller();
            procTask = null;
            continue_flag = false;
        }

        ~Controller()
        {
            Stop();
        }

        public void Start()
        {
            continue_flag = true;
            procTask = new Task(Proc);
            procTask.Start();
        }

        public void Proc()
        {
            controller.Connect();

            while (continue_flag)
            {

            }

            controller.Disconnect();
        }

        public void Stop()
        {
            continue_flag = false;
            if (procTask != null)
            {
                procTask.Wait();
            }
            procTask = null;
        }
    }
}
