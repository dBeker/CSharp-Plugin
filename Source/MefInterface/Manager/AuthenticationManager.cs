using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using MefShared.Interfaces;
using MefShared.Model;

namespace MefShared.Manager
{
    [Export(typeof(IAuthenticationManager))]
    public class AuthenticationManager : IAuthenticationManager
    {

        [ImportMany]
        IEnumerable<Lazy<IAuthentication, IAuthenticationData>> _authentications;

        public AuthenticationResultModel Authenticate(AuthenticationInputModel input)
        {
            var outputModel = new AuthenticationResultModel { Input = input };
            
            var operation = _authentications.FirstOrDefault(a => a.Metadata.AuthenticationType == input.TypeString);
            outputModel.Result = operation == null ? "Implementation cannot be found" : operation.Value.Authenticate(input.Username, input.Password);

            return outputModel;
        }
    }
}
