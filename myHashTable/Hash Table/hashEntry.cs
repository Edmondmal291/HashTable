using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hash_Table
{
    class HashEntry
    {
        public int key;
        private string value;


        public HashEntry()
        {
            this.key = 0;
            this.value = null;
        }
        public void setKey(int k )
        {
            this.key = k;
        }
        public void setValue(string v)
        {
            this.value = v;
        }
        public int getKey()
        {
            return this.key;
        }

        public string getValue()
        {
            return this.value;
        }
    }

}
