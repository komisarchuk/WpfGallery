using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGallery.Entities
{
    public class EFContext : DbContext
    {
        public EFContext() : base("UserConnection")
        {

        }

        public DbSet<Picture> pictures { get; set; }

    }
}
