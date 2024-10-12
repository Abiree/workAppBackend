using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepositories
{
    public interface IActivityRepository
    {
        Task<List<Activity>> GetActivities();
        //test
    }
}
