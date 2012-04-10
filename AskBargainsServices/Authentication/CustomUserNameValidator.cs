using System;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;


namespace AskBargainsServices.Authentication
{
    public class CustomUserNameValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName == null || password == null)
                throw new ArgumentNullException();

            if (!(userName == "AskBargains" && password == "Uwspstar"))
                throw new SecurityTokenException("Unknown Username & Password!");
        }
    }
}