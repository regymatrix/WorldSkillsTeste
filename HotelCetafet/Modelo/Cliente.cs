//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelCetafet.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int codigo { get; set; }
        public int codigoPais { get; set; }
        public int codigoProfissao { get; set; }
        public string nome { get; set; }
        public string Rua { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public Nullable<int> NumeroCasa { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public bool TipoPessoa { get; set; }
        public string Sexo { get; set; }
        public Nullable<System.DateTime> DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
    
        public virtual Pais Pais { get; set; }
        public virtual Profissao Profissao { get; set; }
    }
}
