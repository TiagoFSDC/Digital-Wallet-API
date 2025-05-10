using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Bank.Management.Domain.Model
{
    public sealed class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
