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
        public decimal Total { get; set; }
        public decimal Time { get; set; }
    }

    public class OrderViewModel
    {
        public string Id { get; set; }

        public string OrderCode { get; set; }

        public string SenderName { get; set; }

        public string From { get; set; }

        public string To { get; set; }

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

        public decimal Weight { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public decimal Height { get; set; }

        public decimal Depth { get; set; }

        public decimal Breadth { get; set; }

        public decimal Total { get; set; }

        public int Time { get; set; }
    }
}
