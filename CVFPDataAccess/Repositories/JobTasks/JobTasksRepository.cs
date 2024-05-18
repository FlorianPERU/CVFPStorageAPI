using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.JobTasks
{
    public class JobTasksRepository : IJobTasksRepository
    {
        private readonly CVContext _context;

        public JobTasksRepository(CVContext cVContext)
        {
            _context = cVContext;
        }

        public async Task<ICollection<JobTask>> GetJobTasksByCandidateIdAsync(int candidateId)
        {
            return await _context.JobTasks
                .Where(ach => ach.Experience.CandidateId == candidateId)
                .ToListAsync();
        }
    }
}
