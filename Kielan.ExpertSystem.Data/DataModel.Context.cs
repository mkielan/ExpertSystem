﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kielan.ExpertSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataModelContainer : DbContext
    {
        public DataModelContainer()
            : base("name=DataModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Rules> RulesSet { get; set; }
        public DbSet<Facts> FactsSet { get; set; }
        public DbSet<Patterns> PatternsSet { get; set; }
        public DbSet<Actions> ActionsSet { get; set; }
        public DbSet<SelectedFacts> SelectedFactsSet { get; set; }
        public DbSet<Questions> QuestionsSet { get; set; }
    }
}