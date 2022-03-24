using System;
using System.Threading.Tasks;

namespace DataLogSingleton
{
    public sealed class DataLog
    {
        private static DataLog? _instance;
        public List<string> logs;
        private static readonly object _lock = new object();
        private DataLog()
        {
            logs = new List<string>();
        }
        public static DataLog GetInstance()
        {
            if (_instance == null)
            {
                lock(_lock)
                {
                    _instance = new DataLog();                    
                }
            }
            return _instance;
        }


        public void GravaLog(string mensagem) 
        {
            logs.Add(mensagem);
        }

        public void ApagaLogs()
        {
            logs.Clear();
        }

        public void ImprimeLogs()
        {
            foreach (string mensagem in logs)
            {
                Console.WriteLine(mensagem);
            }
        }
    }
}
