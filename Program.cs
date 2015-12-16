using System;
using System.Linq;
using System.Diagnostics;

namespace MediatRTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            var mediator = new MediatR.Mediator((type) => new QueryHandler(), (type) => Enumerable.Empty<object>());
            for (int i = 0; i < 10000; i++)
            {
                var query = new Query();
                var result = mediator.Send(query); 
            }
            sw.Stop();
            var time = sw.ElapsedMilliseconds;
            Console.WriteLine(time);
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }

    public class Query : MediatR.IRequest<int>
    {
        
    }

    public class QueryHandler : MediatR.IRequestHandler<Query,int>
    {
        public int Handle(Query message)
        {
            return 0;
        }
    }
}
