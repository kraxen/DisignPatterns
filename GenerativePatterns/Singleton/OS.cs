
using System;

namespace GenerativePatterns.Singleton
{
    public class OS
    {
        private static object syncRoot = new Object();
        private static Lazy<OS> _instance;
        public string Name { get; private set; }

        protected OS(string name)
        {
            this.Name = name;
        }

        public static OS getInstance(string name)
        {
            if (_instance == null)
            {
                lock (syncRoot)
                {
                    if (_instance == null)
                        _instance = new(new OS(name));
                }
            }
            return _instance.Value;
        }
    }
}
