using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIBA_BASE_Library
{
    [Serializable]
    public class Order
    {
        public long Id { get; set; }
        public string customerName { get; set; }
        public int quantity { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime orderDate { get; set; }
        public decimal price { get; set; }
        public int unitPrice = 1;



    }
}
