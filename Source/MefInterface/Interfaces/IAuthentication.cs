
using MefShared.Model;

namespace MefShared.Interfaces
{
    public interface IAuthenticationManager
    {
        AuthenticationResultModel Authenticate(AuthenticationInputModel input);
    }
    
    public interface IAuthenticationData
    {
        string AuthenticationType { get; }
    }
    
    public interface IAuthentication
    {
        string Authenticate(string username, string password);
    }
    
}
