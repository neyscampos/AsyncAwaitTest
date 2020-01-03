using System;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncAwaitExemple asyncAwaitExemple = new AsyncAwaitExemple();
            asyncAwaitExemple.DoStuff();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main thread " + i + " ! ");
            }
        }
    }


    public class AsyncAwaitExemple
    {
        public async Task DoStuff()
        {
            await Task.Run(() =>
            {
                CountOneToFifty();
            });

            Console.WriteLine("Background Thread finish" );
        }

        private async Task<string> CountOneToFifty()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Background Thread" + i);
            }

            return ("Task is completed");
        }
    }
}
