//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBCOR
    {
        public TBCOR()
        {
            this.TBCARRO = new HashSet<TBCARRO>();
        }
    
        public int NCDIDCOR { get; set; }
        public string CDSCOR { get; set; }
    
        public virtual ICollection<TBCARRO> TBCARRO { get; set; }
    }
}