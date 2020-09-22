using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skol.Data
{
    public enum Colors { }
    public class Tribe
    {
        [Key]
        public int TribeID { get; set; }
        public string Name { get; set; }
        public Colors Colors{ get; set; }
        public virtual ICollection<Viking> Vikings { get; set; }
    }
}
