using NC.OS.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Data.Configurations
{
    public class PlacesConfiguration : EntityBaseConfiguration<Places>
    {
        public PlacesConfiguration()
        {
            Property(u => u.Id).IsRequired().HasMaxLength(100);
            Property(u => u.Name).IsRequired().HasMaxLength(100);
        }
    }
}
