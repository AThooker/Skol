using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skol.Data
{
    public enum Career { Raider, Farmer, Blacksmith, Trader, King, Slave}
    public class Viking
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TribeID { get; set; }
        public virtual Tribe Tribe { get; set; }
        public int Age { get; set; }
        public int KingdomID { get; set; }
        public virtual Kingdom Kingdom{ get; set; }
        public Career Profession { get; set; }
    }
}
