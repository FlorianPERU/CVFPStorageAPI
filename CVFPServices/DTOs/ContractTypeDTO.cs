using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.DTOs
{
    public class ContractTypeDTO
    {
        public int Id { get; set; }
        public ContractTypeEnum Type { get; set; }
    }
}
