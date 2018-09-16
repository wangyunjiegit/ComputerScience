using Infrastructure.Log.Concrete;
using System;
using System.Threading;

namespace DesignPatterns.Implementation
{
    /// <summary>
    /// 单例:确保一个类只有一个实例，并提供该实例的全局访问点。    
    /// </summary>
    public class Singleton
    {
        private static readonly object obj = new object();
        private static Singleton uniqueInstance;

        /// <summary>
        /// 实例化次数
        /// </summary>
        public static int instantiationsCount = 0;

        /// <summary>
        /// 请求调用实例化次数
        /// </summary>
        public static int requestCount = 0;

        private Singleton() { }

        public static Singleton GetUniqueInstance()
        {
            Interlocked.Increment(ref requestCount);

            if (uniqueInstance == null)
            {
                lock (obj)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new Singleton();
                        instantiationsCount++; 
                    }
                }                
            }

            return uniqueInstance;
        }
    }
}
