using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using WcfTranslationLibrary;

namespace HostApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(TranslationService));
            sh.Open();

            Console.WriteLine("Service was invoked");
            Console.ReadLine();

            sh.Close();
        }
    }
}
