//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace onlinemarketing.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int pro_id { get; set; }
        public string pro_name { get; set; }
        public string pro_image { get; set; }
        public Nullable<int> pro_price { get; set; }
        public string pro_desc { get; set; }
        public Nullable<int> cat_id_fk { get; set; }
        public Nullable<int> pro_user_id_fk { get; set; }
    
        public virtual cateogory cateogory { get; set; }
        public virtual tbl_user tbl_user { get; set; }
    }
}
