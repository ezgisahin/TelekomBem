using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelekomBem.Model
{
    class Marka
    {
        public int Id { get; set; }
        public string MAdi { get; set; }
        public int TID { get; set; }

        [ForeignKey("TID")]
        public virtual Tur Turler { get; set; }

        public virtual ICollection<Mdl> Modeller { get; set; }
    }
}
