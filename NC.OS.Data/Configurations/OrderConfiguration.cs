using NC.OS.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Data.Configurations
{
    public class OrderConfiguration : EntityBaseConfiguration<Order>
    {
        public OrderConfiguration()
        {
            Property(u => u.OrderCode).IsRequired().HasMaxLength(50);
            Property(u => u.SenderName).IsRequired().HasMaxLength(100);
            Property(u => u.SenderPhone).IsRequired().HasMaxLength(50);
            Property(u => u.ReceiverName).IsRequired().HasMaxLength(100);
            Property(u => u.ReceiverPhone).IsRequired().HasMaxLength(50);
            Property(u => u.ReveiverAddress).IsRequired().HasMaxLength(100);
            Property(u => u.Weight).IsRequired();
            Property(u => u.Height).IsRequired();
            Property(u => u.Depth).IsRequired();
            Property(u => u.Breadth).IsRequired();
            Property(u => u.Departure).IsRequired().HasMaxLength(50);
            Property(u => u.Arrival).IsRequired().HasMaxLength(50);
        }
    }
}
