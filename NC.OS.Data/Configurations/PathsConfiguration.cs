using NC.OS.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Data.Configurations
{
    public class PathsConfiguration :  EntityBaseConfiguration<Paths>
    {
        public PathsConfiguration()
        {
            Property(u => u.Id).IsRequired().HasMaxLength(100);
            Property(u => u.PFrom).IsRequired().HasMaxLength(100);
            Property(u => u.PTo).IsRequired().HasMaxLength(100);
            Property(u => u.Size).IsRequired();
            Property(u => u.Route).IsRequired().HasMaxLength(200);

        }
    }
}
