using BeSpokedBikes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Infrastructure
{
    public class DbInitializer
    {
        public static void Initialize(BSBContext context)
        {
            context.Database.EnsureCreated();


        }
    }
}
