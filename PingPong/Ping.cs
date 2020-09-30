using System;
using System.Collections.Generic;
using System.Text;

namespace PingPong
{
    class Ping
    {
        public delegate void HitHandler(string mes);
        public event HitHandler Hit;
        public void Heat()
        {
            Hit?.Invoke("Ping reserved Pong");            
        }
    }
}
