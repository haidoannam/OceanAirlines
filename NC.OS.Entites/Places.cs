using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Entites
{
    public class Places : IEntityBase
    {
        //public Guid Id { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        Guid IEntityBase.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
