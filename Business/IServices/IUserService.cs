using Entities.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    public interface IUserService
    {
        Task<IdentityResult> register(UserDTO user);
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth); 
        Task<string> CreateToken();

    }
}
