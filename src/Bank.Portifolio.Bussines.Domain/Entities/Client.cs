using System;
using System.Collections.Generic;

namespace Bank.Portifolio.Bussines.Domain.Entities
{
    public class Client
    {
        public int IdClient { get; set; }
        public string NameClient { get; set; }
        public string SectorClient { get; set; }
        public string PhoneClient { get; set; }
        public string CellClient { get; set; }
        public DateTime DateRegister { get; set; }
        public DateTime? DateUpdate { get; set; }

        public virtual ICollection<Business> ClientBusiness{ get; set; }
    }
}
