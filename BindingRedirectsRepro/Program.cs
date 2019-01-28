using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingRedirectsRepro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(GSS.Authentication.CAS.Owin.CasAuthenticationMiddleware).Name);
            Console.Read();
        }
    }
}
