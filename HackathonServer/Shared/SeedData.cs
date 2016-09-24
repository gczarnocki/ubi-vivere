using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackathonServer.Models;
using Microsoft.EntityFrameworkCore;

namespace HackathonServer.Shared
{
    public class SeedData
    {
        public static void Initialization()
        {
            var options = new DbContextOptionsBuilder<HackathonContext>();

            using (var context = new HackathonContext(options.Options))
            {
                
            }
        }
    }
}
