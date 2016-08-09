using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using MefShared.Interfaces;

namespace MefShared.Catalogs
{
    public class AuthenticationCatalog
    {
        [Import(typeof(IAuthenticationManager))]
        public IAuthenticationManager Authentication;
        

        public AuthenticationCatalog (string catalogDirectory)
        {
            //An aggregate catalog that combines multiple catalogs
            var catalog = new AggregateCatalog();

            //Adds all the parts found in the same assembly as the Program class
            catalog.Catalogs.Add(new DirectoryCatalog(catalogDirectory));
            catalog.Catalogs.Add(new DirectoryCatalog(".\\"));

            //Create the CompositionContainer with the parts in the catalog
            var container = new CompositionContainer(catalog);

            try
            {
                container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }
        
    }
}
