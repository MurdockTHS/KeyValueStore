using System;
using System.Collections.Generic;
namespace Collections
{
    class Collections
    {
        public static HashSet<int> Hash()
        {
            HashSet<int> numbers = new HashSet<int>(new int[] { 1, 2, 3, 4, 5 });

            return numbers;
        }
        static List<int> List()
        {
            List<int> list = new List<int>(5);

            foreach (int number in new int[] { 1, 2, 3, 4, 5 })
            {
                list.Add(number);
            }

            return list;
        }
        public static LinkedList<int> Link()
        {
            LinkedList<int> numbers = new LinkedList<int>();

            foreach (int number in new int[] { 1, 2, 3, 4, 5 })
            {
                numbers.AddFirst(number);
            }
            return numbers;
        }
        public static Queue<int> Que()
        {
            Queue<int> numbers = new Queue<int>();

            foreach (int number in new int[] { 1, 2, 3, 4, 5 })
            {
                numbers.Enqueue(number);
            }
            return numbers;

        }
        public static Stack<int> Stacker()
        {
            Stack<int> numbers = new Stack<int>();
            foreach (int number in new int[] { 1, 2, 3, 4, 5 })
            {
                numbers.Push(number);
            }
            return numbers;
        }
        public static Dictionary<string, int> Dict()
        {
            Dictionary<string, int> shoppingCart = new Dictionary<string, int>();

            shoppingCart.Add("Sony AX50", 1);
            shoppingCart.Add("Logitech Webcam", 1000);
            shoppingCart.Add("phone charger", 5);
            shoppingCart.Add("picture frame", 2);

            return shoppingCart;
        }
        public static SortedList<string, int> Sort()
        {
            SortedList<string, int> shoppingCart = new SortedList<string, int>();

            shoppingCart.Add("Sony ax50", 1);
            shoppingCart.Add("Logitech Webcam", 1000);
            shoppingCart.Add("phone charger", 5);
            shoppingCart.Add("picture frame", 2);

            return shoppingCart;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Collections ");
            Console.WriteLine("\n HashSet:");
            foreach (var item in Hash())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n List:");
            foreach (var item in List())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n LinkedList:");
            foreach (var item in Link())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n Queue:");
            foreach (var item in Que())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n Stack:");
            foreach (var item in Stacker())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n Dictionary:");
            foreach (var item in Dict())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n SortedList:");
            foreach (var item in Sort())
            {
                Console.WriteLine(item);
            }
        }
    }
}