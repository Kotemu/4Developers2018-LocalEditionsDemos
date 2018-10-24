using System;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Bonus.CustomAwaiter
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var button = new Button();

            //We did it! We are able to await our button object!
            await button;
        }
    }
}
