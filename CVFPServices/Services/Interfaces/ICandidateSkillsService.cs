﻿using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Services.Interfaces
{
    public interface ICandidateSkillsService
    {
        public Task<CandidateSkillsDTO> GetCandidateSkillsDTOByUserIdAsync(int userId);

    }
}
