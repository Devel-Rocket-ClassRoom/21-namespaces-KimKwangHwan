using System;
using System.Collections.Generic;
using System.Text;

namespace Formal
{
    class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"{name}님, 안녕하십니까!");
        }
        public void SayBye(string name)
        {
            Console.WriteLine($"{name}님, 안녕히 가십시오!");
        }
    }
}

namespace Casual
{
    class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"안녕, {name}!");
        }
        public void SayBye(string name)
        {
            Console.WriteLine($"잘 가, {name}!");
        }
    }
}