using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogIncelemeDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Nlog Database adımları
            // Database hazırlığo => Sp
            // App.config içerisinde (database yolu)
            // Nlog paket dosyaları
            // Nlog.config ayarlaması
            // loglama işlemini test
            #endregion

            #region App.Config içerisinde yaptıklarım
            //< connectionStrings >
            //< add name = "Nlog" connectionString = "Data Source=DESKTOP-O9HL0H1\SQLEXPRESS;Initial Catalog=UdemyNlogDatabase;Integrated Security=True" />

            // </ connectionStrings >
            #endregion

            #region NLog.config içerisinde yaptıklarım
            //< target xsi: type = "Database" name = "databese" connectionString = "Nlog" commandText = "exec dbo.LOGMEKAYDET @Level,@Mesaj" >       
            //< parameter name = "@Level" layout = "${level}" />         
            //< parameter name = "@Mesaj" layout = "${message}" />           
            //</ target >

            //< logger levels = "Error,Warn,Fatal" name = "databaselogger" writeTo = "database" />
            #endregion

            try
            {
                int sayi1 = 0;
                int sonuc = 10 / sayi1;
            }
            catch (Exception ex) 
            {
                Logger logger = LogManager.GetLogger("databaselogger");
                logger.Error(ex.Message);
            }
        }
    }
}
