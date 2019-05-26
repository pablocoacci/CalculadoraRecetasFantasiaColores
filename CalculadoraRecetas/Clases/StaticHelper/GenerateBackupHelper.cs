using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRecetas.Clases.StaticHelper
{
    public static class GenerateBackupHelper
    {
        private static string _pathOriginal = ConfigurationManager.AppSettings.Get("databasefilepath");
        private static string _partialPath = ConfigurationManager.AppSettings.Get("backupath");
        private static string _backupName = ConfigurationManager.AppSettings.Get("backupname");

        public static bool GenerarBackup()
        {
            Directory.CreateDirectory(_partialPath);
            string pathBackup = _partialPath + @"\" + _backupName + "_" + DateTime.Now.ToString("yyyyMMdd") + ".zip";

            try
            {
                //Comprimir
                ZipFile.CreateFromDirectory(_pathOriginal, pathBackup);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
