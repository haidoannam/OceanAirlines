﻿using NC.OS.Data.Configurations;
using NC.OS.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Data.Context
{
    public class OceanAirlinesContext : DbContext
    {
        public OceanAirlinesContext()
            : base("OceanAirlines")
        {
            Database.SetInitializer<OceanAirlinesContext>(null);
        }

        #region Entity Sets
        public IDbSet<User> UserSet { get; set; }

        #endregion

        public virtual void Commit()
        {
            base.SaveChanges();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new UserConfiguration());
           
        }
    }
}
