using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRecetas.Clases.StaticHelper
{
    public static class LogErrorHelper
    {
        public static bool LogError(Exception ex)
        {
            try
            {
                string fileName = "LogError" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
                string partialPah = Directory.GetCurrentDirectory() + "\\LogError\\";
                Directory.CreateDirectory(partialPah);
                string fullPath = partialPah + fileName;

                StreamWriter logError;
                if (System.IO.File.Exists(fullPath))
                    logError = new StreamWriter(fullPath, true);
                else
                    logError = File.AppendText(fullPath);

                logError.WriteLine("------------------------------------------------------------------------------------------------------");
                logError.WriteLine("------------------------------------------------------------------------------------------------------");
                logError.WriteLine("Fecha Error: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                logError.WriteLine("------------------------------------------------------------------------------------------------------");
                logError.WriteLine("Mensaje error: " + ex.Message);
                logError.WriteLine("------------------------------------------------------------------------------------------------------");
                logError.WriteLine(ex.StackTrace);

                logError.Flush();
                logError.Close();
                return true;
            }
            catch //(Exception excep)
            {
                return false;
            }
        }
    }
}
