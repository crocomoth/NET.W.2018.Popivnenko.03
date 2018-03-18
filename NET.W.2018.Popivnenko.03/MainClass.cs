using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._03
{
    public static class MainClass
    {
        public static void Main()
        {
            EvklidProj.ClassicEvklid evklid = new EvklidProj.ClassicEvklid();
            long time1 = 0;
            long time2 = 0;
            evklid.ClassicEvklidMethod(64, 48);
            time1 = evklid.GetTimeOfExecution();
            evklid.BinaryEvklidMethod(64, 48);
            time2 = evklid.GetTimeOfExecution();
            time1 = 0;
        }
    }
}
