using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelekomBem.Model
{
    class Mdl
    {
        public int Id { get; set; }
        public string MoAdi { get; set; }

        public int TID { get; set; }
        public int MaID { get; set; }

        [ForeignKey("TID")]
        public virtual Tur Turler { get; set; }

        [ForeignKey("MaID")]
        public virtual Marka Markalar { get; set; }
    }
}
