using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Model
{
    public class OrderModel
    {
        public SenderModel Sender { get; set; }

        public ReceiverModel Receiver { get; set; }

        public PackageModel Package { get; set; }
    }

    public class OrderResultModel
    {
        public double Total { get; set; }
        public double Time { get; set; }
    }

    public class OrderViewModel
    {
        public double Total { get; set; }
        public double Time { get; set; }
    }

    public class SenderModel
    {
        public string Name { get; set; }

        public string Phone { get; set; }

    }

    public class ReceiverModel
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }

    public class PackageModel
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public double Height { get; set; }

        public double Depth { get; set; }

        public double Breadth { get; set; }

        public double Total { get; set; }

        public int Time { get; set; }
    }
}
