using System.ComponentModel.DataAnnotations;

namespace ProvidersAPI.Models
{
    public class Provider
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string LegalName { get; set; }

        [StringLength(255)]
        public string TradeName { get; set; }

        [StringLength(11)]
        public string TaxId { get; set; }

        [Phone]
        [StringLength(255)]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }

        [Url]
        [StringLength(255)]
        public string Website { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        [DataType(DataType.Currency)]
        public decimal? AnnualBillingUSD { get; set; }

        public DateTime? LastEdited { get; set; }
    }
}
