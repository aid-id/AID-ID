﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkConsole
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_diabetesEntities4 : DbContext
    {
        public db_diabetesEntities4()
            : base("name=db_diabetesEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alimentos> Alimentos { get; set; }
        public virtual DbSet<Analisis> Analisis { get; set; }
        public virtual DbSet<Comidas> Comidas { get; set; }
        public virtual DbSet<Comidas_alimentos> Comidas_alimentos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}