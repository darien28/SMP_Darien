﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMP
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_SMPEntities : DbContext
    {
        public DB_SMPEntities()
            : base("name=DB_SMPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_CAT> TB_CAT { get; set; }
        public virtual DbSet<TB_supp> TB_supp { get; set; }
        public virtual DbSet<Tb_pur> Tb_pur { get; set; }
        public virtual DbSet<TB_Users> TB_Users { get; set; }
    }
}
