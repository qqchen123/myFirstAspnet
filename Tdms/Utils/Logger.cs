using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Tdms.Utils
{
    public class Logger
    {
        private ILog loger = null;
        /// <summary>
        /// 读取配置文件---静态构造函数---整个进程执行且只执行一次；
        /// </summary>
        static Logger() {
            XmlConfigurator.Configure(
                new FileInfo(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"ConfigFiles\\log4net.config")
                    )
                );

            ILog Log = LogManager.GetLogger(typeof(Logger));

            Log.Info("系统初始化Logger模块");
        }

        

        public Logger(Type type) {
            loger = LogManager.GetLogger(type);
        }


        public void Error(string msg="出现异常",Exception ex=null)
        {
            Console.WriteLine(msg);
            loger.Error(msg,ex);
        }

        public void Warn(string msg)
        {
            Console.WriteLine(msg);
            loger.Warn(msg);
        }

        public void Info(string msg)
        {
            Console.WriteLine(msg);
            loger.Info(msg);
        }

        public void Debug(string msg)
        {
            Console.WriteLine(msg);
            loger.Debug(msg);
        }





    }
}