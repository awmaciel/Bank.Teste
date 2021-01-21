using System;

namespace Bank.Portifolio.Bussines.Domain.Entities
{
    public class Business
    {
        public Business()
        {
            //Client = new Client();
            //Category = new Category();
            //Portifolio = new Portifolio();
        }
        public int IdBusiness { get; set; }
        public int IdPortifolio { get; set; }
        public int IdCategory { get; set; }
        public int IdClient { get; set; }
        public string TypeBusiness { get; set; }
        public decimal ValueBusiness { get; set; }
        public DateTime DateRegister { get; set; }
        public DateTime? DateUpdate { get; set; }

        public virtual Category Category { get; set; }
        public virtual Portifolio Portifolio{ get; set; }
        public virtual Client Client { get; set; }

        public Business ValidateBusiness(Business business, Client client)
        {
            if (business.ValueBusiness < 1000000 && client.SectorClient == "Private")
                business.IdCategory = 1;
            else
                business.IdCategory = 3;

            if (business.ValueBusiness < 1000000 && client.SectorClient == "Public")
                business.IdCategory = 1;
            else if (business.ValueBusiness > 1000000 && client.SectorClient == "Public")
                business.IdCategory = 2;

            business.DateRegister = DateTime.Now;
            business.DateUpdate = null;
            return business;
        }
    }
}
