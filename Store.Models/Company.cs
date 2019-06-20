using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Store.Models
{
    [DataContract]
    public class Company
    {
        [Key] [DataMember] public int Id { get; set; }
        [DataMember] public string PersianName { get; set; }
        [DataMember] public string EnglishName { get; set; }
        [DataMember] public int CountryId { get; set; }
        public Country Country { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}