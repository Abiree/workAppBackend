using Entities.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
namespace Business.IServices
{
    public interface IUserActivityService
    {
        Task<List<Activity>> GetUsersActivity();
    }
}
