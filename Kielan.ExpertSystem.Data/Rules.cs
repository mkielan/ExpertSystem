//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Rules
    {
        public Rules()
        {
            this.Actions = new HashSet<Actions>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public long PatternsId { get; set; }
    
        public virtual ICollection<Actions> Actions { get; set; }
        public virtual Patterns Patterns { get; set; }
        public virtual Patterns Conclusion { get; set; }
    }
}
