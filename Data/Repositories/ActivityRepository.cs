using Data.IRepositories;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ActivityRepository : IActivityRepository
    {

        private readonly DataContext _dataContext;
        public ActivityRepository(DataContext datacontext)
        {
            _dataContext = datacontext;
        }

        public Task<List<Activity>> GetActivities()
        {
            return _dataContext.Activities.ToListAsync();
        }
    }
}
