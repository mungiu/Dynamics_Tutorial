using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Andrei";
            obj.GetHashCode();

            ////////////////////////// using REFLECTION ///////////////

            ////same as above (messy and dificult)
            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);

            ////////////////////////// using DYNAMICS /////////////////

            //object excelObject = "excelInfo";
            //excelObject.Optimize();           ////won't work, method not existent

            ////same as reflection but cleaner code
            //dynamic excelObject = "mosh";       
            //excelObject.Optimize();

            //NOTE: "name" is easelly converted from string to int since its "dynamic"
            dynamic name = "Andrei";
            name = 10;
            name++;     //NOTE: won;t work if name is string

            Console.WriteLine(name);

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;  //NOTE: var becomes "dynamic"
            c = "asd";

            Console.WriteLine(c);
        }
    }
}
