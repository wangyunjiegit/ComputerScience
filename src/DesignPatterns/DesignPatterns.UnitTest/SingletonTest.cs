using DesignPatterns.Implementation;
using System;
using System.Collections.Generic;
using System.Threading;
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
            var taskList = new List<Task>();
            for (int i = 0; i < 10000; i++)
            {                
                var task = Task.Run(() => {
                    var instance = Singleton.GetUniqueInstance();                    
                });

                taskList.Add(task);
            }

            taskList.ForEach(x => {
                if (x.Status != TaskStatus.RanToCompletion)
                {
                    x.Wait();
                }
            });

            var count1 = Singleton.instantiationsCount;//此处实例化次数为1说明正确实现了单例模式
            var count2 = Singleton.requestCount;//并发请求数量
        }
    }
}
