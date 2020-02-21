using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EFDALItem.Models
{
    [Table("Order")]
   public class Order
    {
        [Key]
        public int order_id { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int item_id { get; set; }
        //Navigate Property
        [ForeignKey("item_id")]
        public Item Item { get; set; }
    }
}
