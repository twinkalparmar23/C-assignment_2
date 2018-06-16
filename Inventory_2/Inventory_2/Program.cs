using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,count = 0;

            List<string> items = new List<string>();

            items.Add("Tomato");
            items.Add("Potato");
            items.Add("ToMato");
            items.Add("Potato");
            items.Add("Red Tomato");
            items.Add("Tomato Catchup");
            items.Add("Grapes");
            items.Add("grapes");
            items.Add("potato");
            
            //Food[] list =
            //{
            //    new Food("Tomato"),
            //    new Food("Potato"),
            //    new Food("ToMato"),
            //    new Food("Potato"),
            //    new Food("Red Tomato"),
            //    new Food("Tomato  Catchup"),
            //    new Food("Grapes"),
            //    new Food("grapes"),
            //    new Food("potato")

            //};
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            foreach (var a in items)
            {
                if ((a.IndexOf("tomato", StringComparison.CurrentCultureIgnoreCase) >= 0))
                {
                    count = count + 1;
                }
            }

            //foreach (var x in items)
            //{
            //    if ((string.Compare(x, "tomato", StringComparison.CurrentCultureIgnoreCase)) == 0)
            //        count = count + 1;
            //}

            Console.WriteLine("\n number of string containing tomato :" + count);


            i = items.FindIndex(x => x.Equals("Potato", StringComparison.CurrentCulture));
            Console.WriteLine("\n Potato found at index:" + (i + 1));
            
        }
    }
}
