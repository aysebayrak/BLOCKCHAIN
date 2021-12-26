using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BLOCKCHAIN.Models
{
    public class Market
    {

        [Key]
        [ForeignKey("Wallet")]
        public string productName { get; set; }
        public int productPrice { get; set; }
    }
}
