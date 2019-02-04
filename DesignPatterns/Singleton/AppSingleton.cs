using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public class AppSingleton
    {
        private static AppSingleton _singleInstance;
        private static readonly object _lockObject = new object();

        private AppSingleton()
        { }

        public static AppSingleton GetInstance()
        {
            if (_singleInstance == null)
            {
                lock(_lockObject)
                {
                    if (_singleInstance == null)
                        _singleInstance = new AppSingleton();
                }
            }

            return _singleInstance;
        }
    }
}
