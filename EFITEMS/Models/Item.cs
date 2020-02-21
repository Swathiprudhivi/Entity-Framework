using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EFITEMS.Models
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public int item_id { get; set; }
        [Required] //set not null
        [StringLength(30)]
        public string item_name { get; set; }
        public int? Price { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
