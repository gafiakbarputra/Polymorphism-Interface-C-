using System;

namespace printer
{
    public interface IPrinterWindows
    {
        void Show();
        void Print();
    }
    public class Epson : IPrinterWindows
    {
        public string name = "Epson";
        public string dimension = "10*11";
        public virtual void Show()
        {
            Console.WriteLine($"{name} display dimension : {dimension}");
        }
        public virtual void Print()
        {
            Console.WriteLine($"{name} printer printing...");
        }
    }
    public class Canon : IPrinterWindows
    {
        public string name = "Canon";
        public string dimension = "9.5*12";
        public virtual void Show()
        {
            Console.WriteLine($"{name} display dimension : {dimension}");
        }
        public virtual void Print()
        {
            Console.WriteLine($"{name} printer printing...");
        }
    }
    public class LaserJet : IPrinterWindows
    {
        public string name = "LaserJet";
        public string dimension = "12*12";
        public virtual void Show()
        {
            Console.WriteLine($"{name} display dimension : {dimension}");
        }
        public virtual void Print()
        {
            Console.WriteLine($"{dimension} printer printing...");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            IPrinterWindows printer;
            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");
            Console.Write("Nomor Printer [1..3]:");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            if (nomorPrinter == 1)
            {
                printer = new Epson();
            }
            else if (nomorPrinter == 2)
            {
                printer = new Canon();
            }
            else
            {
                printer = new LaserJet();
            }
            printer.Show();
            printer.Print();
            Console.ReadKey();
        }
    }
}
