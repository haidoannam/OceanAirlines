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

        public double Weight { get; set; }
        public double Depth { get; set; }
        public double Breadth { get; set; }

        public double Height { get; set; }
        public string Departure { get; set; }

        public string Arrival { get; set; }

        public double ToTal { get; set; }

        public int Time { get; set; }

    }
}
