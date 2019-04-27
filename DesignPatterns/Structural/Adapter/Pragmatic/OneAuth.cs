using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FbAuth
{
    public sealed class FacebookAuth
    {
        public static void Login() { Console.WriteLine("Facebook Authorization"); }
    }
}

namespace GoogleAuth
{
    public sealed class GoogleAuthorization
    {
        public static void SignIn() { Console.WriteLine("Google Authorization"); }
    }
}

namespace CustomAuth
{
    public sealed class CustomAuthorization
    {
        public static void AuthorizeUser() { Console.WriteLine("Custom Authorization"); }
    }
}

namespace DesignPatterns.Structural.Adapter.Pragmatic
{
    public interface IAuthProvider
    {
        void Authorize();
    }

    public class AuthProvider : IAuthProvider
    {
        private AuthType _authType;
        public AuthProvider(AuthType authType)
        {
            _authType = authType;
        }
        public void Authorize()
        {
            switch (_authType)
            {
                case AuthType.CUSTOM:
                    CustomAuth.CustomAuthorization.AuthorizeUser();
                    break;
                case AuthType.FB:
                    FbAuth.FacebookAuth.Login();
                    break;
                case AuthType.GOOGLE:
                    GoogleAuth.GoogleAuthorization.SignIn();
                    break;
                default:
                    break;
            }
        }
    }
    public enum AuthType
    {
        CUSTOM, FB, GOOGLE
    }
}

