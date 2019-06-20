﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Store.Models
{
    [DataContract]
    public class Category
    {
        [Key] [DataMember] public int Id { get; set; }
        [DataMember] public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}