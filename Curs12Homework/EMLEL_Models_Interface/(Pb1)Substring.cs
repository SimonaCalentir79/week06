using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLEL_Models_Interface
{
    
    public static class Rezolvare
    {
        public static StringBuilder Substring(this StringBuilder stringBuilder, int index, int length)
        {
            //----------------VARIANTA 1----------------//
            //string str = stringBuilder.ToString();
            //string strExtract = str.Substring(index, length);
            //stringBuilder = new StringBuilder(strExtract);
            //return stringBuilder;

            //----------------VARIANTA 2----------------//
            string str = stringBuilder.ToString();
            char[] arrString = str.ToCharArray();
            char character;
            string newStr = null;

            for (int i = index; i < length+index; i++)
            {
                character = arrString[i];
                newStr = newStr + character;
            }
            StringBuilder extras = new StringBuilder(newStr);
            return extras;
        }

        public static void Pb01()
        {
            StringBuilder newString = new StringBuilder("ABC"+"DEF"+"GHI");
            Console.WriteLine($"\n\t {newString.ToString()}");

            StringBuilder extras = newString.Substring(2, 5);
            Console.WriteLine($"\n\t {extras.ToString()}");
        }
    }
}
