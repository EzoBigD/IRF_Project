﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace C19_Tracker
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CoronaTracker_DBEntities : DbContext
    {
        public CoronaTracker_DBEntities()
            : base("name=CoronaTracker_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agy> Agies { get; set; }
        public virtual DbSet<Allapot> Allapots { get; set; }
        public virtual DbSet<Beoszta> Beosztas { get; set; }
        public virtual DbSet<Beteg> Betegs { get; set; }
        public virtual DbSet<Orvo> Orvos { get; set; }
        public virtual DbSet<Terem> Terems { get; set; }
    }
}