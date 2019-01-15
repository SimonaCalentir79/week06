using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using CTS_Models_Interface;

namespace CommonTypeSystem
{
    class Program
    {
        static void Main()
        {
            //Rog comentati si, respectiv, de-comentati pe rand rezolvarile ca sa fie mai usor de urmarit
            DataAndExecution.Pb02();

            DataAndExecution.Pb03();

            DataAndExecution.Pb04();

            DataAndExecution.Pb05();

            //DataAndExecution.Pb06(); - nerezolvata

            Console.ReadLine();
        }
    }
}
