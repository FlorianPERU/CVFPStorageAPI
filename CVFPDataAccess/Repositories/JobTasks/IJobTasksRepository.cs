using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.JobTasks
{
    public interface IJobTasksRepository
    {
        public Task<ICollection<JobTask>> GetJobTasksByUserIdCandidate(int userId);
    }
}
