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
    
    public partial class TBLOCACAO
    {
        public int NCDIDLOCACAO { get; set; }
        public Nullable<int> NCDIDUSUARIO { get; set; }
        public Nullable<System.DateTime> DDTLOCACAO { get; set; }
        public Nullable<decimal> NVLLOCACAO { get; set; }
        public Nullable<System.DateTime> DDTDEVOLUCAO { get; set; }
        public Nullable<int> NCDIDCARTAO { get; set; }
        public Nullable<int> NCDIDCARRO { get; set; }
    
        public virtual TBCARRO TBCARRO { get; set; }
        public virtual TBCARTAODECREDITO TBCARTAODECREDITO { get; set; }
        public virtual TBUSUARIO TBUSUARIO { get; set; }
    }
}