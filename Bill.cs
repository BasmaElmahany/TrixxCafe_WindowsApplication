using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trixx_CafeSystem
{
    internal class Bill
    {
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        public double Price_Of_Product { get; set; }
        [Required]
        public string Name_Of_Product { get; set; }
        public int Product_Qty { get; set; }
        public double Payment_Amount { get; set; }

        [ForeignKey("Products")]
        public int ProductID { get; set; }
        public virtual Product Products { get; set; }
        public virtual Order Order { get; set; }
    }
}
