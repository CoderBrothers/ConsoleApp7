using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Crisps
    {
        #region PrivateFields
        private double _weight;
        private string _taste;
        private double _price;
        private string _title;
        private static int _counter;
        private int _id; 
        #endregion
        #region Properties
        public string Title
        {
            get => _title;
            set
            {
                if (value.Trim() != String.Empty) _title = value;
            }
        }
        public string Taste
        {
            get => _taste;
            set
            {
                if (value.Trim() != String.Empty) _taste = value;
            }
        }
        public double Weight
        {
            get => _weight;
            set
            {
                if (value >= 50 && value < 300) _weight = value;
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                if (value > 0 && value < 120) _price = value;
            }
        }
        public static int Counter => _counter;
        public int Id => _id;

        #endregion
        #region Methods
        public void Buy() => Console.WriteLine($"Я купил чипсы {Title}.");
        public void About() => Console.WriteLine($"Я купил чипсы за {Price}грн :\nВес: {Weight}гр\nВкус: {Taste}");
        public static void GetCount() => Console.WriteLine($"Создано {Counter} уп. чипсов");
        #endregion
        #region Constructors
        public Crisps() : this("Lays") { Console.WriteLine(1); }
        public Crisps(string title) : this(title, 150) { Console.WriteLine(2); }
        public Crisps(string title, double weight) : this(title, weight, 45) { Console.WriteLine(3); }
        public Crisps(string title, double weight, double price) : this(title, weight, price, "Краб") { Console.WriteLine(4); }
        public Crisps(string title, double weight, double price, string taste)
        {
            Console.WriteLine(5);
            Title = !String.IsNullOrWhiteSpace(title) ? title : "Lays";
            Weight = weight;
            Price = price;
            Taste = !String.IsNullOrWhiteSpace(taste) ? taste : "Краб";
            _counter++;
            _id = _counter;
        }

        #endregion
    }

}
