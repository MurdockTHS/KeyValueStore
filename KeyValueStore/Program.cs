using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
    class Program
    {
        // Collaborated with Phillip Koller, Jenny Mun, and Gus. We did our best to complete the assignment
        public struct KeyValue<T>
        {
            public readonly string Key;
            public readonly T Value;
            public KeyValue(string key, T value)
            {
                this.Key = key;
                this.Value = value;
            }
        }
        public class MyDictionary
        {
            KeyValue<int>[] keys = new KeyValue<int>[5];

            public int storedValue = 0;


            public object this[string keyIndex]
            {

                get
                {
                    for (int i = 0; i < keys.Length; i++)
                    {
                        if (keyIndex == keys[i].Key)
                        {
                            return keys[i].Value;
                        }

                    }
                    throw new KeyNotFoundException("That key was not found");
                }

                set
                {
                    bool found = true;
                    for (int i = 0; i < storedValue; i++)
                    {
                        if (this.keys[i].Key == keyIndex)
                        {
                            this.keys[i] = new KeyValue<int>(keyIndex, (int)value);
                        }
                        found = false;

                    }
                    if (found == false)
                    {
                        keys[storedValue] = new KeyValue<int>(keyIndex, (int)value);
                    }
                    storedValue++;

                }

                //set { arr[i] = value; }

                //get { return arr[i]; }
            }
        }
        static void Main(string[] args)
        {
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }
    }
}
