using System;
using System.Collections.Generic;

namespace Bank.Portifolio.Bussines.Domain.Entities
{
    public class Portifolio
    {
        public int IdPortifolio { get; set; }
        public string NameProtifolio { get; set; }
        public DateTime DateRegister { get; set; }
        public DateTime? DateUpdate { get; set; }

        public virtual ICollection<Business> Businesses { get; set; }
    }
}
