//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NguyenLucSongNguyen.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<int> category_id { get; set; }
        public string description { get; set; }
        public Nullable<byte> isOnSale { get; set; }
        public Nullable<double> salePrice { get; set; }
        public Nullable<int> brand_id { get; set; }
        public Nullable<bool> type_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
        [NotMapped]
        public bool ShowDropdown { get; set; }
    }
}
