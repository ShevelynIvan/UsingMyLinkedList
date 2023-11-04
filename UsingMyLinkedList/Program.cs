using DataStructures;
using CarLibrary;

namespace UsingMyLinkedList
{
    internal class Program
    {
        /// <summary>
        /// Demonstrates to examples using MyLinkedList with value type and reference type. 
        /// It necessary only for Remove(T value) method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MyLinkedList<int> ints = new MyLinkedList<int>();
            ints.AddNext(777);
            ints.AddNext(999);
            ints.AddFirst(1);
            ints.AddFirst(2);
            ints.AddNext(100);
            ints.PrintAllPoints(); 
            
            Console.WriteLine();

            ints.Clear();
            ints.AddNext(3);
            ints.AddFirst(69);
            ints.AddNext(4);
            ints.PrintAllPoints();

            Console.WriteLine();

            ints.Remove(3);
            ints.PrintAllPoints();

            Console.WriteLine();

            MyLinkedList<Car> cars = new MyLinkedList<Car>();
            cars.AddFirst(null);
            cars.AddNext(new Car("Audi", "Black"));
            cars.AddFirst(new Car("BMW", "Brown"));
            cars.AddNext(new Car("Kia", "Red"));
            cars.AddFirst(new Car("Porshe", "White"));
            cars.PrintAllPoints();

            Console.WriteLine();

            cars.Remove(new Car("BMW", "Brown"));
            cars.Remove(null);
            cars.PrintAllPoints();
        }
    }
}