﻿using CVFPDataAccess.Models;
using CVFPDataAccess.Repositories.JobTasks;
using CVFPServices.DTOs;
using CVFPServices.Extensions;
using CVFPServices.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Services
{
    public class JobTasksService : IJobTasksService
    {

        private readonly IJobTasksRepository _jobTasksRepository;
        public JobTasksService(IJobTasksRepository jobTasksRepository) 
        {
            _jobTasksRepository = jobTasksRepository;
        }

        public async Task<ICollection<JobTaskDTO>> GetJobTasksDTOByCandidateIdAsync(int candidateId)
        {
            var jobTasks = await _jobTasksRepository.GetJobTasksByCandidateIdAsync(candidateId);
            return jobTasks.Select(e => e.ToDTO()).ToList();
        }
    }
}
