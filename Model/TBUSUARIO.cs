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
    
    public partial class TBUSUARIO
    {
        public TBUSUARIO()
        {
            this.TBLOCACAO = new HashSet<TBLOCACAO>();
        }
    
        public int NCDIDUSUARIO { get; set; }
        public string CNMLOGIN { get; set; }
        public string CDSSENHA { get; set; }
        public Nullable<int> NNRNIVELACESSO { get; set; }
        public Nullable<int> NCDIDFUNCIONARIO { get; set; }
        public Nullable<bool> BIDATIVO { get; set; }
    
        public virtual TBFUNCIONARIO TBFUNCIONARIO { get; set; }
        public virtual ICollection<TBLOCACAO> TBLOCACAO { get; set; }
    }
}