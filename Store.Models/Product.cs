using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Store.Models
{
    [DataContract]
    public class Product
    {
        [Key] [DataMember] public int Id { get; set; }

        [DataMember] public string ModelName { get; set; }
        [DataMember] public string Description { get; set; }

        [DataMember] public int BrandId { get; set; }
        public Company Brand { get; set; }

        [DataMember] public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}