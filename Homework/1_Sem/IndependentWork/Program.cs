using System;
namespace IndependentWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Independent work - {DateTime.Now.ToShortDateString()}");
            CognacManager manager = new CognacManager();
            Console.WriteLine("Get by procuder country");
            string proc = Console.ReadLine();
            var cognacs = manager.GetByCountry(proc);
            if (cognacs == null || cognacs.Count == 0)
            {
                Console.WriteLine("Not found");
                return;
            }
            foreach (var cognac in cognacs)
            {
                Console.WriteLine(cognac.ToString());
            }
        }
    }
}