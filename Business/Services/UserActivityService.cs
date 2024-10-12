using Business.IServices;
using Data.IRepositories;
using Entities.Dtos;
using Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserActivityService : IUserActivityService
    {

        private readonly UserManager<User> _userManager;
        private readonly IActivityRepository _activityRepository;

        public UserActivityService(UserManager<User> userManager, IActivityRepository activityRepository)
        {
            _userManager = userManager;
            _activityRepository = activityRepository;

        }

        public async Task<List<Activity>> GetUsersActivity()
        {

            var result = await _activityRepository.GetActivities();
            return result;




        }
    }
}
