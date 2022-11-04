using System;
using Jindium;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            JinServer server = new JinServer();

            server.Start();
        }
    }
}
