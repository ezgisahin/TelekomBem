using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelekomBem.Model
{
    class Tur
    {
        public int Id { get; set; }
        public string TAdi { get; set; }

        public virtual ICollection<Marka> Markalar { get; set; }
        public virtual ICollection<Mdl> Modeller { get; set; }


    }
}
