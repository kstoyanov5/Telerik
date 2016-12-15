/*
 * Full description of the homework can be seen at:
 * https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/01.%20Defining-Classes-Part-1/homework 
 */

namespace Problem.GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class GSMTest
    {
        static void Main(string[] args)
        {            
            List<GSM> gsmHolder = new List<GSM>();

            //GSM samsungS4 = new GSM("s4", "samsung");
            GSM samsungS3 = new GSM("s3", "samsung", "500 marki", "Kolio Mamata", new Battery(Battery.BatteryType.LiIon), new Display("500p", "200 hilqdi"));
            //gsmHolder.Add(samsungS4);
            gsmHolder.Add(samsungS3);

            Console.WriteLine(GSM.Iphone4.ToString());

            foreach (var gsm in gsmHolder)
            {
                Console.WriteLine(gsm.ToString());
            }
        }
    }
}
