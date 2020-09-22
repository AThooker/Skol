using Skol.Data;
using Skol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skol.Services
{
    public class TribeService
    {
        public bool CreateTribe(TribeCreate model)
        {
            var ctx = new ApplicationDbContext();
            var tribe = new Tribe()
            {
                Name = model.Name,
                Colors = model.Colors
            };
            ctx.Tribes.Add(tribe);
            return ctx.SaveChanges() == 1;
        }
    }
}
