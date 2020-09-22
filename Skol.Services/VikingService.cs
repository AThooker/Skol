using Skol.Data;
using Skol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skol.Services
{
    public class VikingService
    {
        public bool CreateViking(VikingCreate model)
        {
            var ctx = new ApplicationDbContext();
            var viking = new Viking()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
            }
        }
    }
}
