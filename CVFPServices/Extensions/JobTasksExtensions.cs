using CVFPDataAccess.Models;
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions
{
    public static class JobTasksExtensions
    {
        public static JobTaskDTO ToDTO(this JobTask jobTask)
        {
            return new JobTaskDTO
            {
                Id = jobTask.Id,
                Task = jobTask.Task,
                Position = jobTask.Position,
                ExperienceId = jobTask.ExperienceId
            };
        }
    }
}