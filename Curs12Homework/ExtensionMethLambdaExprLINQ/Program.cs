using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMLEL_Models_Interface;

namespace ExtensionMethLambdaExprLINQ
{
    class Program
    {
        static void Main()
        {
            //Rog comentati si, respectiv, de-comentati pe rand rezolvarile ca sa fie mai usor de urmarit
            Rezolvare.Pb01();

            MethodsIEnum.Pb02();

            Student.Pb03();

            Student.Pb04();

            Student.Pb05();

            IntArray.Pb06();

            Timer.Pb07();

            //Pb08 - nerezolvata

            StudentGr.DisplayStudents();

            StudentGr.Pb09();

            StudentGr.Pb10();

            StudentGr.Pb11();

            StudentGr.Pb12();

            StudentGr.Pb13();

            StudentGr.Pb14();

            StudentGr.Pb15();

            StudentGr.Pb16();

            //Pb17 - nerezolvata

            StudentGr.Pb18();

            StudentGr.Pb19();

            //Pb20 - nerezolvata

            Console.ReadLine();
        }
    }
}
