using System;

namespace Bank.Portifolio.Bussines.Domain.Entities
{
    public class Business
    {
        public int IdBusiness { get; set; }
        public int IdPortifolio { get; set; }
        public int IdCategory { get; set; }
        public int IdClient { get; set; }
        public string TypeBusiness { get; set; }
        public DateTime DateRegister { get; set; }
        public DateTime DateUpdate { get; set; }

        public virtual Category CategoryBusiness { get; set; }
        public virtual Portifolio PortifolioBusiness { get; set; }
        public virtual Client ClientBusiness { get; set; }
    }
}
