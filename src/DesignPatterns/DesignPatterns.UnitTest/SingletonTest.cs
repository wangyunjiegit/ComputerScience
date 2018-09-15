using DesignPatterns.Implementation;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatterns.UnitTest
{
    /// <summary>
    /// ��������:ȷ��һ����ֻ��һ��ʵ�������ṩ��ʵ����ȫ�ַ��ʵ㡣
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
                    var pause = "this is pause";
                });
            }            
        }
    }
}
