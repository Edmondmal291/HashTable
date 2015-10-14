using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hash_Table
{
     class HashTable
    {
        private static int increment =  0;
        const int Table_Size = 6759;
        HashEntry[] Table;

        public HashTable()
        {
            Table = new HashEntry[Table_Size];
            for (int i = 0; i < Table_Size; i++)
                Table[i] = new HashEntry();
        }
        private int updateI()
        {
            return increment++;
        }

        // Put method 
        public void put(int key, string value)
        {
            int hash = (key+1) % Table_Size;
            if (Table[hash].getKey()==0&&Table[hash].getValue()==null)
            {
                //insert
                Table[hash].setKey(key);
                Table[hash].setValue(value);
            }
            else if (Table[hash].getKey()!=0 || Table[hash].getKey() != key)
            {
                int collision = (7*hash+1)% Table_Size;
                Table[collision].setKey(key);
                Table[collision].setValue(value);
            }
            
         }

         // Quadratic method 
        public void quadratic(int key, string value)
        {
            int hash = (key + increment) % Table_Size;
            int Qudratic = (hash + increment + square(increment) % Table_Size);
            if (Table[Qudratic].getKey() == 0 && Table[Qudratic].getValue() == null)
            {
                Table[Qudratic].setKey(key);
                Table[Qudratic].setValue(value);
            }
            else
                for (int i = 0; i < Table_Size; i++)
                    hash = (hash + i + square(i)) % Table_Size;
                    if (Table[hash].getKey() == 0 && Table[hash ].getValue() == null)
                    {
                        Table[hash].setKey(key);
                        Table[hash].setValue(value);
                    }


        }

        // linear probing 
        public void LinearProbing(int key, string value)
        {
            int hash = (key + increment) % Table_Size;
            if (Table[hash].getKey()==0&&Table[hash]==null)
            {
                // insert
                Table[hash].setKey(key);
                Table[hash].setValue(value);
                
            }
            else if (Table[hash] != null || Table[hash].getKey() != key)
            {
                for (int i = 0; i < Table_Size; i++)
                {
                    Table[hash].setKey(key);
                    Table[hash].setValue(value);
                }
            }
            updateI();
            
        }

         // return 
        public string get(int key)
        {
            int hash = (key+1) % Table_Size;
            int collision = (7 * hash + 1) % Table_Size;
            if (Table[hash].getKey() == key)
            {

                return Table[hash].getValue();
            }
            //int collision = (7 * hash + 1) % Table_Size;

            else if (Table[collision].getKey() == key)
            {
                return Table[collision].getValue();
            }
            else
            {
                return Error();
            }
         }

         // error method 
        private string Error()
        {
            string error=("Key could not be found");
            return error;
        }

         // squareing method 
        private int square(int i)
        {
            return i * i;
        }
 
    }
}
