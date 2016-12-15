namespace Problem.GSM
{
    using System;
    using System.Linq;

    // VNIMANIE!! Tova e vtori Main class, molq ,za da proverite kak raboti natisnete dqsno kop4e vurhu Problem.GSM -> Properties -> StartUp Object -> izberete Problem.GSMCallHistoryTest
    public class GSMCallHistoryTest
    {
        static void Main()
        {
            float pariVMinuta = 0.37f;

            var gsm = new GSM("S6","Samsung","450 marki", "Patkan", new Battery(Battery.BatteryType.NiCd,"Anker","2", "2"), new Display("720p", "20 000 000"));
            gsm.addCall(new Call("24.02/2016", "17:00", 08888888, 5));
            gsm.addCall(new Call("27.03/2016", "11:00", 08888888, 50));
            gsm.addCall(new Call("29.12/2016", "12:00", 08888888, 15));

            foreach (var calls in gsm.PhoneCallHistory)
            {
                Console.WriteLine(calls.ToString());
            }
            Console.WriteLine("Your smetka is: {0} leva", gsm.calculateCallPrices(pariVMinuta));

            gsm.deleteCall(gsm.PhoneCallHistory.OrderByDescending(x => x.Duration).First());

            Console.WriteLine("Your new smetka is: {0} leva", gsm.calculateCallPrices(pariVMinuta));

            gsm.clearCallHistory();

           foreach (var calls in gsm.PhoneCallHistory)
           {
                //Nqma da se slu4i ni6to ,za6toto e prazno :). Da im imam usloviqta :D
                Console.WriteLine(calls);
           }
        }
    }
}
