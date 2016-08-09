using System;
using MefShared.Catalogs;
using MefShared.Model;

namespace MefTrial
{

    class Program
    {
        static void Main(string[] args)
        {
            var p = new AuthenticationCatalog(".\\Plugin\\"); //Composition is performed in the constructor

            while (true)
            {
                var res = p.Authentication.Authenticate(new AuthenticationInputModel
                {
                    TypeString = Console.ReadLine()
                });
                if(res != null)
                Console.WriteLine(res.Result);
            }
        }
    }
}
