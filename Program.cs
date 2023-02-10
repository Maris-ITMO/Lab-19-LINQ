using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_19_СамРабота_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>
            {
                new Computer() { Code = "C001", Brand = "Dell", ProcessorType = "Intel Core i7", ProcessorFrequency = 3200, RAM = 16, HardDrive = 512, VideoMemory = 4, Price = 1500, Quantity = 10 },
                new Computer() { Code = "C002", Brand = "HP", ProcessorType = "Intel Core i5", ProcessorFrequency = 2600, RAM = 8, HardDrive = 256, VideoMemory = 2, Price = 800, Quantity = 20 },
                new Computer() { Code = "C003", Brand = "Acer", ProcessorType = "AMD Ryzen 5", ProcessorFrequency = 3600, RAM = 16, HardDrive = 512, VideoMemory = 4, Price = 1300, Quantity = 15 },
                new Computer() { Code = "C004", Brand = "Asus", ProcessorType = "Intel Core i3", ProcessorFrequency = 2400, RAM = 4, HardDrive = 128, VideoMemory = 2, Price = 500, Quantity = 30 },
                new Computer() { Code = "C005", Brand = "MSI", ProcessorType = "AMD Ryzen 7", ProcessorFrequency = 4000, RAM = 32, HardDrive = 1024, VideoMemory = 8, Price = 2000, Quantity = 5 },
                new Computer() { Code = "C005", Brand = "Lenovo", ProcessorType = "AMD Ryzen 7", ProcessorFrequency = 3200, RAM = 16, HardDrive = 1000, VideoMemory = 4, Price = 500, Quantity = 20 },
                new Computer() { Code = "C006", Brand = "Dell", ProcessorType = "AMD Ryzen 7", ProcessorFrequency = 3500, RAM = 16, HardDrive = 512, VideoMemory =6, Price = 700, Quantity = 30 },
                new Computer() { Code = "C007", Brand = "MSI", ProcessorType = "AMD Ryzen 7", ProcessorFrequency = 2900, RAM = 8, HardDrive = 256, VideoMemory = 2, Price = 400, Quantity = 15 },
                new Computer() { Code = "C008", Brand = "MSI", ProcessorType = "AMD Ryzen 7", ProcessorFrequency = 3100, RAM = 12, HardDrive = 512, VideoMemory = 4, Price = 600, Quantity = 25 },
                new Computer() { Code = "C009", Brand = "MSI", ProcessorType = "AMD Ryzen 7", ProcessorFrequency = 2500, RAM = 4, HardDrive = 128, VideoMemory = 2, Price = 300, Quantity = 10 },
                new Computer() { Code = "C010", Brand = "MSI", ProcessorType = "AMD Ryzen 7", ProcessorFrequency = 2700, RAM = 8, HardDrive = 56, VideoMemory = 4, Price = 450, Quantity = 20 },
            };

            Console.WriteLine("Введите тип процессора:");
            string processorType = Console.ReadLine();

            Console.WriteLine("Введите минимальный объем оперативной памяти:");
            int minimumRAM = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите минимальный объем поставки:");
            int minimumQuantity = int.Parse(Console.ReadLine());

            var computersWithSelectedProcessor = computers.Where(c => c.ProcessorType == processorType);
            Console.WriteLine("Компьютеры с выбранным процессором:");
            foreach (var computer in computersWithSelectedProcessor)
            {
                Console.WriteLine("Code: " + computer.Code + ", Brand: " + computer.Brand + ", Processor Type: " + computer.ProcessorType + ", Processor Frequency: " + computer.ProcessorFrequency + ", RAM: " + computer.RAM + ", Hard Drive: " + computer.HardDrive + ", Video Memory: " + computer.VideoMemory + ", Price: " + computer.Price + ", Quantity: " + computer.Quantity);
            }

            var computersWithSelectedRAM = computers.Where(c => c.RAM >= minimumRAM);
            Console.WriteLine("Компьютеры с выбранной оперативной памятью:");
            foreach (var computer in computersWithSelectedRAM)
            {
                Console.WriteLine("Code: " + computer.Code + ", Brand: " + computer.Brand + ", Processor Type: " + computer.ProcessorType);
            }

            var computersWithQuantity = computers.Where(c => c.Quantity >= minimumQuantity);
            Console.WriteLine("Компьютеры с минимальный объем поставки:");
            foreach (var computer in computersWithQuantity)
            {
                Console.WriteLine("Code: " + computer.Code + ", Brand: " + computer.Brand + ", Processor Type: " + computer.ProcessorType);
            }
            Console.ReadKey();
        }
    }
}
