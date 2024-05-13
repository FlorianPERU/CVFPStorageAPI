﻿using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
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

        public ICollection<HardSkill> GetHardSkillsByUserIdCandidate(int userId)
        {
            return _context.AssociationCandidatesHardSkills.Where(acss => acss.CandidateId == userId).Select(ss => ss.HardSkill).ToList();
        }
    }
}