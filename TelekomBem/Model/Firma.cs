using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TelekomBem.Model
{
    class Firma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FirmaId { get; set; }
        [StringLength(50)]
        public string FirmaAdi { get; set; }
        public string Adres { get; set; }
        [StringLength(50)]
        public string Tel { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Vd { get; set; }
        [StringLength(50)]
        public string Vn { get; set; }
    }
}
