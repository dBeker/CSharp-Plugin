using System.ComponentModel.Composition;
using MefShared.Interfaces;

namespace MefAuthentication
{
    [Export(typeof(IAuthentication))]
    [ExportMetadata("AuthenticationType", "2")]
    public class SecondAuthentication : IAuthentication
    {
        public string Authenticate(string username, string password)
        {
            return "Authentication Implementation 2 is invoked";
        }
    }
}
