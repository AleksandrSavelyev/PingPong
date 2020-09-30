using System;
using System.Collections.Generic;
using System.Text;

namespace PingPong
{
    class Pong
    {
        public delegate void HitHandler(string mes);
        public event HitHandler Hit;
        public void Heat()
        {
            Hit?.Invoke("Pong reserved Ping");
        }
    }
}
