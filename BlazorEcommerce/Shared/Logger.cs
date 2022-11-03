using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiCall
{
    public class Logger
    {
        private string Path = "";

        public Logger(string Path)
        {
            this.Path = Path;
        }

        public void Add(string sLog)
        {
            CreateDirectory();
            string nombre = GetNameFile();
            string cadena = "";

            cadena += DateTime.Now + " - " + sLog + Environment.NewLine;

            StreamWriter sw = new StreamWriter(Path + "/" + nombre, true);
            sw.Write(cadena);
            sw.Close();
        }

        private string GetNameFile()
        {
            string nombre = "";
            nombre = "log_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".txt";
            return nombre;
        }

        private void CreateDirectory()
        {
            try
            {
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
