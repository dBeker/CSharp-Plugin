using System.ComponentModel.Composition;
using MefShared.Interfaces;

namespace MefAuthentication
{
    [Export(typeof(IAuthentication))]
    [ExportMetadata("AuthenticationType", "3")]
    public class ThirdAuthentication : IAuthentication
    {
        public string Authenticate(string username, string password)
        {
            return "Authentication Implementation 3 is invoked";
        }
    }
}
