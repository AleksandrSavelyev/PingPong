using System;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Ping ping = new Ping();
            Pong pong = new Pong();
            ping.Hit += Inf;
            pong.Hit += Inf;
            ping.Heat();
            pong.Heat();
            Console.ReadKey();
        }
        public static void Inf(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
