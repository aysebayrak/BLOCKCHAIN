using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BLOCKCHAIN.Models
{
    public class Block
    {

        [Key]
        [ForeignKey("Market")]
        public string productName { get; set; }
        public  string buyerKey { get; set; }
        public string sellerKey { get; set; }
        public  int productPrice { get; set; }
        public  DateTime transacitionDate { get; set; }

    }
}
