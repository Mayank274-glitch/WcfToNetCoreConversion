using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Channels;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WcfConsumer.WcfServiceClient;

namespace WcfConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            WcfServiceClient.Service1Client service1Client = new WcfServiceClient.Service1Client();
             
           // var response = service1Client.GetData("test");

            Console.WriteLine(service1Client.GetData("test"));
            Console.Read();
        }
      
    }
}
