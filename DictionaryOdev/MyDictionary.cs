using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryOdev
{
    internal class MyDictionary<T,U>
    {
        T[] dictionaryKey;
        U[] dictionaryValue;
        T[] keyTempArray;
        U[] valueTempArray;

        public MyDictionary()
        {
            dictionaryKey = new T[0];
            dictionaryValue = new U[0];
        }

        public void Add(T key, U value)
        {
            bool varmi = dictionaryKey.Contains(key);
            if (varmi)
            {
                Console.WriteLine("Aynı anahtara sahip bir öğe zaten eklendi.");
            }
            else
            {
                keyTempArray = dictionaryKey;
                dictionaryKey = new T[dictionaryKey.Length + 1];
                for (int i = 0; i < keyTempArray.Length; i++)
                {
                    dictionaryKey[i] = keyTempArray[i];
                }
                dictionaryKey[dictionaryKey.Length - 1] = key;

                valueTempArray = dictionaryValue;
                dictionaryValue = new U[dictionaryValue.Length + 1];
                for (int i = 0; i < valueTempArray.Length; i++)
                {
                    dictionaryValue[i] = valueTempArray[i];
                }
                dictionaryValue[dictionaryValue.Length - 1] = value;
            }
            
        }

        public void Yazdir()
        {
            for(int i = 0; i < dictionaryKey.Length; i++)
            {
                Console.WriteLine(dictionaryKey[i].ToString()+ " " + dictionaryValue[i]); 
            }
            
        }
    }
}
