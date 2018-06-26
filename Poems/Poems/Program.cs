using System;
using System.Linq;
using System.Reflection;

namespace Poems
{
    class Program
    {
        static void Main()
        {
            IPoem randomPoem = GetRandomPoem();
            Console.WriteLine(randomPoem.Text);

            Console.ReadKey();
        }

        private static IPoem GetRandomPoem()
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Type randomPoemType = myAssembly
                .DefinedTypes
                .Where(t => t.ImplementedInterfaces.Contains(typeof(IPoem)))
                .OrderBy(x => Guid.NewGuid())
                .First();

            return (IPoem) Activator.CreateInstance(randomPoemType);
        }
    }
}
