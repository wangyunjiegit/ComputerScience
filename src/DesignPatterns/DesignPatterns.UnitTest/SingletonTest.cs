using DesignPatterns.Implementation;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatterns.UnitTest
{
    /// <summary>
    /// 单例测试:确保一个类只有一个实例，并提供该实例的全局访问点。
    /// </summary>
    public class SingletonTest
    {
        [Fact]
        public void Main()
        {
            for (int i = 0; i < 1000; i++)
            {                
                Task.Run(() => {
                    var instance = Singleton.GetUniqueInstance();
                    //var pause = "this is pause";
                });
            }            
        }
    }
}
