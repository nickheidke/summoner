﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Summoner.Clients;

namespace Summoner.Notifications
{
    public class ConsoleNotification : Notification
    {
        private readonly ConfigurationDictionary configuration;

        public ConsoleNotification(ConfigurationDictionary configuration)
        {
            this.configuration = configuration;
        }

        public ConfigurationDictionary Configuration
        {
            get
            {
                return configuration;
            }
        }

        public void Notify(Client client, Message message)
        {
            Console.WriteLine(message.Time + " / " + client.Name + " / " + message.Sender + " / " + message.Content);
        }
    }
}
