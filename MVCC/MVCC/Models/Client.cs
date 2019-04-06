using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCC.Models
{
    public enum PayType
    {
        Cash,
        CreditCard
    }
    
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        public string Name { get; set; }
        public int NIT { get; set; }

        [Required]
        public PayType Pay { get; set; }
    }
}