using Infrastructure.Log.Concrete;
using System;

namespace DesignPatterns.Implementation
{
    /// <summary>
    /// 单例:确保一个类只有一个实例，并提供该实例的全局访问点。    
    /// </summary>
    public class Singleton
    {
        private static Singleton uniqueInstance;

        private Singleton() { }

        public static Singleton GetUniqueInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();

                new LogHelper().WriteLog("testtt");
            }

            return uniqueInstance;
        }
    }
}
