using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BLOCKCHAIN.Models
{
    public class Wallet
    {
        [Key]
        [ForeignKey("User")]
       public string userKey { get; set; }
       public string productName { get; set; }


    }
}
