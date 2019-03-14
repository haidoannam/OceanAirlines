using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Entites
{
    public class User : IEntityBase
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    
    }
}
