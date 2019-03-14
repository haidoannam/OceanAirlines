using NC.OS.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        OceanAirlinesContext dbContext;

        public OceanAirlinesContext Init()
        {
            return dbContext ?? (dbContext = new OceanAirlinesContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
