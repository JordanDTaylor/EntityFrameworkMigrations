using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cintera.DAL
{
    public class CinteraContext : DbContext
    {
        public CinteraContext()
            :base("CinteraContext")
        {

        }

        public DbSet<Case> Cases { get; set; }
    }
}
