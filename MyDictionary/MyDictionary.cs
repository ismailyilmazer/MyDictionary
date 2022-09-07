using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<Tkey, Tval>
    {
        KeyValuePair<Tkey, Tval>[] items;

        public MyDictionary()
        {
            items= new KeyValuePair<Tkey, Tval>[0];

        }

        public void Add(Tkey tKey,Tval tVal)
        {
            KeyValuePair<Tkey, Tval>[] tempItems = items;
            

            if (!Control(tKey))
            {
                Console.WriteLine("Error! Key value should be only one");
                
            }
            else
            {
                items = new KeyValuePair<Tkey, Tval>[tempItems.Length + 1];
                items[items.Length - 1 ] = new KeyValuePair<Tkey, Tval>(tKey,tVal); ;
            }

            for(int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }

        }

        private bool Control(Tkey tKey)
        {
            bool control = true;
            foreach (var item in items)
            {
                if (item.Key.ToString() == tKey.ToString())

                { control = false; }
                
            }
            return control;
        }
        public void Show()
        {
            foreach(var item in items)
                {
                Console.WriteLine(item);
                };
        }



    }
}
