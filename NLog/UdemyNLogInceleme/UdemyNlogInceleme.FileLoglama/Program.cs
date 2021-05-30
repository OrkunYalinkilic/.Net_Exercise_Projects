﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyNlogInceleme.FileLoglama
{
    class Program
    {
        static void Main(string[] args)
        {
            #region NLog.Config içerisinde yaptıklarım
            //< target xsi: type = "File" name = "udemyfilenloginfo" fileName = "${basedir}/Info/${shortdate}.log"
            //          layout = "${longdate} ${uppercase:${level}} ${message}" />

            //< target xsi: type = "File" name = "udemyfilenlogWarn" fileName = "${basedir}/Warn/${shortdate}.log"
            //          layout = "${longdate} ${uppercase:${level}} ${message}" />

            //< logger name = "*" level = "Info" writeTo = "udemyfilenloginfo" />

            //< logger name = "*" level = "Warn" writeTo = "udemyfilenlogWarn" />

            #endregion

            var Logger = NLog.LogManager.GetCurrentClassLogger();
            Logger.Log(LogLevel.Info,$"Proje Başladı {DateTime.Now.ToString("dd.MM.yyyy hh:ss")}");
            Logger.Log(LogLevel.Warn, $"Proje Uyarı Mesajı");
            Logger.Log(LogLevel.Info, $"Proje Bitti {DateTime.Now.ToString("dd.MM.yyyy hh:ss")}");

        }
    }
}
