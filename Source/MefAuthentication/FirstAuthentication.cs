using System.ComponentModel.Composition;
using MefShared.Interfaces;

namespace MefAuthentication
{
    [Export(typeof(IAuthentication))]
    [ExportMetadata("AuthenticationType", "1")]
    public class FirstAuthentication : IAuthentication
    {
        public string Authenticate(string username, string password)
        {
            return "Authentication Implementation 1 is invoked";
        }
    }
}
