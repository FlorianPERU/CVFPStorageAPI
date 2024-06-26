﻿using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.HardSkills
{
    public class HardSkillsRepository : IHardSkillsRepository
    {
        private readonly CVContext _context;

        public HardSkillsRepository(CVContext cVContext)
        {
            _context = cVContext;
        }

        public async Task<ICollection<HardSkill>> GetHardSkillsByCandidateIdAsync(int candidateId)
        {
            return await _context.AssociationCandidatesHardSkills
                .Where(acss => acss.CandidateId == candidateId)
                .Include(chs => chs.HardSkill)
                .ThenInclude(hs => hs.HardSkillType)
                .Include(hs => hs.HardSkill.AssociationCandidateHardSkills)
                .Select(ss => ss.HardSkill).ToListAsync();
        }
    }
}
