using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Log.Abstract
{
    /// <summary>
    /// 接口-日志工具
    /// </summary>
    public interface ILogHelper
    {
        /// <summary>
        /// 写入日志到指定路径
        /// </summary>
        /// <param name="msg">要写入的信息</param>
        void WriteLog(string msg,string path);
    }
}
