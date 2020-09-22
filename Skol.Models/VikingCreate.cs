using Skol.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skol.Models
{
    public class VikingCreate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Colors { get; set; }
        public int Age { get; set; }
        public string Symbol { get; set; }
        public Career Profession { get; set; }
    }
}
