using System.ComponentModel.DataAnnotations;

namespace APIC.Models
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