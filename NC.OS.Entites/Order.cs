using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Entites
{
    public class Order : IEntityBase
    {
        public Guid Id { get; set; }

        public string OrderCode { get; set; }
        public string SenderName { get; set; }
        public string SenderPhone { get; set; }

        public string ReceiverName { get; set; }

        public string ReceiverPhone { get; set; }
        public string ReveiverAddress { get; set; }

        public decimal Weight { get; set; }
        public decimal Depth { get; set; }
        public decimal Breadth { get; set; }

        public decimal Height { get; set; }
        public string Departure { get; set; }

        public string Arrival { get; set; }

        public decimal ToTal { get; set; }

        public int Time { get; set; }

    }
}
