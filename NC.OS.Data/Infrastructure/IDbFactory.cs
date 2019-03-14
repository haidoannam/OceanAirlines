using NC.OS.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        OceanAirlinesContext Init();
    }
}
