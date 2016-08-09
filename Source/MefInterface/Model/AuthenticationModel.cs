namespace MefShared.Model
{
    public class AuthenticationInputModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string TypeString { get; set; }
       
    }

    public class AuthenticationResultModel
    {
        public AuthenticationInputModel Input { get; set; }
        public string Result { get; set; }
    }
}
