using System;

namespace DataLogSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataLog dataLog1 = DataLog.GetInstance();
            DataLog dataLog2 = DataLog.GetInstance();

            if (dataLog1 == dataLog2)
            {
                dataLog1.GravaLog("Both DataLog contain the same instance.");
            }
            else
            {
                dataLog1.GravaLog("DataLog contain differente instances.");
            }

            dataLog1.ImprimeLogs();
            dataLog2.ApagaLogs();

            dataLog2.GravaLog("Desenvolvido por Carlos Castro");
            dataLog2.ImprimeLogs();
        }
    }
}
