//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentLife
{
    using System;
    using System.Collections.Generic;
    
    public partial class organization
    {
        public int id { get; set; }
        public string passphrase { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string orgDescription { get; set; }
    
        public virtual hap hap { get; set; }
    }
}
