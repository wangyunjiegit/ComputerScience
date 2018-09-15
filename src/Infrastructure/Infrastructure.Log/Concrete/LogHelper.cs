using Infrastructure.Log.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infrastructure.Log.Concrete
{
    public class LogHelper : ILogHelper
    {
        private string logDefaultDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
        
        /// <summary>
        /// 默认日志路径
        /// </summary>
        private string LogDefaultPath
        {
            get
            {
                var path = Path.Combine(logDefaultDir, DateTime.Now.ToString("yyyyMMdd"));
                return Path.ChangeExtension(path, "log");
            }
        }

        /// <summary>
        /// 写入日志到指定路径，当不提供指定路径时，默认写入当前目录的Log文件夹下 以当天日期保存
        /// </summary>
        /// <param name="msg">要写入的信息</param>
        /// <param name="path">指定写入的文件路径</param>
        public void WriteLog(string msg, string path = null)
        {
            var logPath = string.IsNullOrEmpty(path) ? LogDefaultPath : path;
            var logDir = Path.GetDirectoryName(logPath);
            if (!Directory.Exists(logDir))
            {
                Directory.CreateDirectory(logDir);
            }

            using (StreamWriter sw = new StreamWriter(logPath, true,Encoding.UTF8))
            {
                sw.WriteLine($"{DateTime.Now.ToString()}:{msg}");
            }
        }
    }
}
