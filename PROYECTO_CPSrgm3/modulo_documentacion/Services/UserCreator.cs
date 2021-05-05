using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commons.Identity.Services;
using CommonsCps.Services;
using Microsoft.AspNetCore.Identity;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Services
{
    public class UserCreator : CommonsCps.Services.UserCreator<Usuario>
    {
        public UserCreator(UserService<Usuario> userService) : base(userService)
        {
        }

        public Task<IdentityResult> CreateUserAsync(string userName, string mail, string password)
        {
            var result = base.CreateUserAsync(CpsSession.Uat,userName, mail, password);

            return result;
        }
    }
}
