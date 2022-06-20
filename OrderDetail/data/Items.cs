using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDetail.data
{
    public class Items
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        [Key]
        public int ID { get; set; }
        
        public string? ItemName { get; set; }

        public int ItemRate { get; set; }
        public int ItemQTY { get; set; }



        
    }
}
