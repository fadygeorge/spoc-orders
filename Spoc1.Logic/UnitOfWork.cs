using spoc1.Data;
using spoc1.Logic.DataAccess;
using Spoc1.Data;
using Spoc1.Logic.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace spoc1.Logic
{
    public class UnitOfWork
    {
        private readonly Context dbcontext;

        public UnitOfWork(Context dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public void Commit()
        {
            dbcontext.SaveChanges();
        }

        AgentRepo agent;
        OrderRepo order;
        PharmacyRepo pharmacy;
        DistributorRepo distributor;
        ProductRepo product;
        ProductOrderRepo productOrder;
        ManagerRepo manager;
        AdminRepo admin;
        

        public AgentRepo Agent => agent ?? (agent = new AgentRepo(dbcontext));
        public OrderRepo Order => order ?? (order = new OrderRepo(dbcontext));
        public PharmacyRepo Pharmacy => pharmacy ?? (pharmacy = new PharmacyRepo(dbcontext));

        public DistributorRepo Distributor => distributor ?? (distributor = new DistributorRepo(dbcontext));

        public ProductRepo Product => product ?? (product = new ProductRepo(dbcontext));

        public ProductOrderRepo ProductOrder => productOrder ?? (productOrder = new ProductOrderRepo(dbcontext));

        public ManagerRepo Manager => manager ?? (manager = new ManagerRepo(dbcontext));

        public AdminRepo Admin => admin ?? (admin = new AdminRepo(dbcontext));
    }
}
