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
    
    public partial class TBCLIENTE
    {
        public TBCLIENTE()
        {
            this.TBCARTAODECREDITO = new HashSet<TBCARTAODECREDITO>();
        }
    
        public int NCDIDCLIENTE { get; set; }
        public string CNMNOME { get; set; }
        public string CNMSOBRENOME { get; set; }
        public string CDSRG { get; set; }
        public string CDSCPF { get; set; }
        public Nullable<System.DateTime> DDTNASCIMENTO { get; set; }
        public Nullable<bool> BIDATIVO { get; set; }
        public Nullable<long> CCDCNH { get; set; }
        public Nullable<System.DateTime> DDTEMISSAO { get; set; }
        public Nullable<System.DateTime> DDTVENCIMENTO { get; set; }
    
        public virtual ICollection<TBCARTAODECREDITO> TBCARTAODECREDITO { get; set; }
    }
}
