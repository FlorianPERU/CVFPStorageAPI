using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.Candidates
{
    public interface ICandidatesRepository
    {
        public Candidate GetFirstCandidate();
    }
}
