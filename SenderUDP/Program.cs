using System;

namespace SenderUDP
{
    class Program
    {
        private const int PORT = 7;

        static void Main(string[] args)
        {
            Sender sender = new Sender(PORT);
            sender.start();

            Console.ReadLine();
        }
    }
}
