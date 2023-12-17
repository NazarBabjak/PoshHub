using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace host_PoshHub
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var host= new ServiceHost(typeof(wcf_PoshHub.ServicePoshHub)))
            {
                host.Open();
                Console.WriteLine("Хост працює!");
                Console.ReadLine();
            }

        }
    }
}
