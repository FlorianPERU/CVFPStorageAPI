using CVFPDataAccess.Models;
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions
{
    public static class JobExtensions
    {
        public static  JobDTO ToDTO(this Job job)
        {
            return new JobDTO
            {
                Id = job.Id,
                Name = job.Name
            };
        }
    }
}