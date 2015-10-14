using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Hash_Table
{
    class fileInputReader
    {
        string file;
        fileInputReader()
        {
        }
        public void setFile(string f)
        {
            this.file = f;
        }
        public string getFile()
        {
            return file;
        }

        public void readfileINt(string f)
        {
            
            StreamReader sr = new StreamReader(f);
            sr.ReadLine();
        }
    }
}
