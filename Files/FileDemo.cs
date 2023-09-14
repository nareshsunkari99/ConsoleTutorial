using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTutorial.Files
{
    public  class FileDemo
    {
        public void ReadFile()
        {
            FileStream fileStream=null;
            StreamReader streamReader=null;
            try
            {
              fileStream   = new("c:\\install.log", FileMode.Open, FileAccess.Read);
               streamReader = new (fileStream);
                Console.WriteLine(streamReader.ReadLine());
            }
            catch { }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();
                if (fileStream != null)
                    fileStream.Close();
            }
            
            
        }

        public void WriteFile(string input)
        {
            FileStream fileStream = null;
            StreamWriter  streamWriter = null;
            try
            {
                fileStream = new("Z:\\new.txt", FileMode.Append, FileAccess.Write);
                streamWriter = new(fileStream);
               streamWriter.WriteLine(input);
            }
            catch { }
            finally
            {
                if (streamWriter != null)
                    streamWriter.Close();
                if (fileStream != null)
                    fileStream.Close();
            }


        }
    }
}
