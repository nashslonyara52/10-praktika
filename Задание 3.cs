using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_3
{
    internal class Laptop
    {
        private int ram;
        private int battery;

        public int Ram
        {
            get { return ram; }
            set
            {
                if (value < 1 || value > 64)
                {
                   Console.WriteLine("ОЗУ должно быть от 1 до 64!");
                   return;
                }
                ram = value;
            }
        }

        public int Battery
        {
            get { return battery; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Заряд батареи должен быть от 0 до 100%!");
                    return;
                }
                battery = value;
            }
        }

        public object Brand { get; private set; }

        public Laptop(string brand, int ram, int battery) : base() 
        {
            Ram = ram;   
            Battery = battery;
        }

        public void Work()
        {
            Console.WriteLine($"Ноутбук {Brand}, ОЗУ: {Ram} ГБ, заряд: {Battery}%.");
        }

        
    }
    internal class Device
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Бренд не может быть пустым или null.");
                brand = value;
            }
        }

        public Device(string brand)
        {
            Brand = brand;
        }

        public virtual void PowerOn()
        {
            Console.WriteLine($"{Brand} включён.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("Dell", 16, 85);
            _ = laptop.PowerOn();
            laptop.Work();

            laptop.Work();

            Console.WriteLine();

            laptop.Ram = 0;

            Console.WriteLine();

            laptop.Work();

        }

    }
}
