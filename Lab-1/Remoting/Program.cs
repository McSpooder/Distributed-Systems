using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace Remoting
{
    public class Program
    {
        static void Main(string[] args)
        {
            TcpChannel chan = new TcpChannel(5000);
            ChannelServices.RegisterChannel(chan, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Translator), "translator", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();            
        }
    }

    public class Translator : MarshalByRefObject
    {

        public string Translate(string in_str)
        {
            string[] words = in_str.Split(' ');

            string result = "";

            foreach (string word in words)
            {
                result += word.Substring(1);
                result += word.Substring(0,1) + "ay";

            }

            return result;

        }


    }
}
