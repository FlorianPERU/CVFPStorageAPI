﻿using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.Hobbies
{
    public interface IHobbiesRepository
    {
        public ICollection<Hobbie> GetHobbiesByUserIdCandidate(int userId);
    }
}
