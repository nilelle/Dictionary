using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    internal class MyDictionary<Tkey,Tvalue>
       
    {
        Tkey[] keys;
        Tvalue[] values;
        public MyDictionary()
        {
            keys = new Tkey[0]; 
            values = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tempKeys = keys;
            Tvalue[] tempValues = values;
            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[keys.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                tempKeys[i] = keys[i];
            }

            for (int i = 0; i < tempValues.Length; i++)
            {
                tempValues[i] = values[i];
            }

            key = keys[keys.Length - 1];
            value = values[values.Length - 1];
        }

            

        public int Count
        {
            get { return keys.Length; }
            
        }

    }

    }


