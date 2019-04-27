using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton _instance;
        private static readonly object _lock = new object();
        private Singleton()
        {
            Console.WriteLine(++counter);
        }

        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                            counter++;
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
