using System;
using System.Collections.Generic;

namespace Bank.Portifolio.Bussines.Domain.Entities
{
    public class Category
    {
        public int IdCategory { get; set; }
        public string NameCategory { get; set; }
        public DateTime DateRegister { get; set; }
        public DateTime? DateUpdate { get; set; }

        public virtual ICollection<Business> BusinessesCategory { get; set; }
    }
}
