using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class ContractType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [EnumDataType(typeof(ContractTypeEnum))]
        public ContractTypeEnum Type { get; set; }
        public required virtual ICollection<Experience> Experiences { get; set; }

    }
    public enum ContractTypeEnum
    {
        CDI,
        CDD,
        Mission,
        Alternance
    }
}
