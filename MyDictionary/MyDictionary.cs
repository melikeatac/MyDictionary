using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }
        public void Add(K key,V value)
        {
            K[] TempKeys = keys;//Önceki değerleri kaybetmemek için kullanılır.
            V[] TempValues = values;//Önceki değerleri kaybetmemek için kullanılır.
            keys = new K[keys.Length + 1];//dizinin eleman sayısı 1 arttırılır.
            values = new V[values.Length + 1];//dizinin eleman sayısı 1 arttırılır.
            for (int i = 0; i <TempKeys.Length; i++)
            {
                keys[i] = TempKeys[i];
                values[i] = TempValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
    }
}
