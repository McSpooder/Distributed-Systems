using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.SignalR.Client;


namespace ServerBackEnd
{
    class Program
    {
        static protected HubConnection connection;
        static List<string> taken_usernames = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            connection = new HubConnectionBuilder().WithUrl("http://localhost:51259/ChatHub").Build();
        }

        static bool checkAvailability(string pUsr)
        {
            foreach (string usr in taken_usernames)
            {
                if (pUsr == usr)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
