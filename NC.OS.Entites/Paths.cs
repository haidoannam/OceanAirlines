using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Entites
{
    public class Paths : IEntityBase
    {
        public string Id { get; set; }

        public string PFrom { get; set; }

        public string PTo { get; set; }

        public int Size { get; set; }

        public string Route { get; set; }
        Guid IEntityBase.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
