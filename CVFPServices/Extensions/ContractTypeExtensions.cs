using CVFPDataAccess.Models;
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions
{
    public static class ContractTypeExtensions
    {
        public static ContractTypeDTO ToDTO(this ContractType contractType)
        {
            return new ContractTypeDTO
            {
                Id = contractType.Id,
                Type = contractType.Type
            };
        }
    }
}