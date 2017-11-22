using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntity.Models
{
   public class SozlukKelime
    {
        [Key]
        public int SozlukKelimeID { get; set; }
        public string KelimeTR { get; set; }
        public string KelimeEN { get; set; }
        public string KelimeESP { get; set; }
    }
}
