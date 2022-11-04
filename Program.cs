using System;
using Jindium;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;

            JinServer server = new JinServer();

            server.ServerRoutes.AddStaticRoute("/hello", Method.GET, async(ctx) =>
            {
                await ctx.Send("Hello World!");
            });

            server.ServerRoutes.AddStaticRoute("/counter", Method.GET, async(ctx) =>
            {
                counter ++;

                if(counter < 50)
                {
                    await ctx.Send(Convert.ToString(counter));
                }
                else
                {
                    await ctx.Send("You are a winner!");
                    counter = 0;
                }
            });

            server.Start();
        }
    }
}
