using Microsoft.EntityFrameworkCore;
using spoc1.Data;
using spoc1.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spoc1.Logic.DataAccess
{
    public class OrderRepo : Repository<Order>
    {
        Context context;
        UnitOfWork unitOfWork;
        public OrderRepo(Context context) : base(context)
        {
            this.context = context;
            unitOfWork = new UnitOfWork(context);
        }

        public IEnumerable<Order> GetOrdersAgent(int AgentId)
        {
            return AsQueryable().Include(s=>s.Pharmacy).Where(w => w.Agent.Id == AgentId);
        }

        public Order GetOrder(int id)
        {

            return AsQueryable().Include(o => o.Agent).ThenInclude(o=>o.Manager).Include(s => s.Pharmacy).Include(s => s.Distributor).Include(s=>s.Products).ThenInclude(s=>s.Product).Where(w => w.Id == id).FirstOrDefault();

        }

        public IEnumerable<Order> GetOrdersManager(int ManagerId)
        {
            return AsQueryable().Include(s=>s.Pharmacy).Include(s=>s.Agent).Where(w => w.Agent.Manager.Id == ManagerId);
        }

        public IEnumerable<Order> GetOrdersManagerByAgentName(string AgentName, int ManagerId)
        {

            return AsQueryable().Include(s => s.Pharmacy).Include(s => s.Agent).Where(w => (w.Agent.Name == AgentName) && (w.Agent.Manager.Id == ManagerId));
        }


        public IEnumerable<Order> GetOrdersAdmin(int AdminId)
        {
            return AsQueryable().Include(s => s.Pharmacy).Include(s => s.Agent).Where(w => w.Agent.Manager.Admin.Id == AdminId);
        }

        public IEnumerable<Order> GetOrdersAdminByAgentName(string AgentName, int AdminId)
        {
            return AsQueryable().Include(s => s.Pharmacy).Include(s => s.Agent).Where(w => (w.Agent.Name == AgentName) && (w.Agent.Manager.Admin.Id == AdminId));
        }


        public void CreateOrder(Order model)
        {
            
            //var order = new Order
            //{

            //    BranchName = model.BranchName,
            //    ValueOfExpiredGoods = model.ValueOfExpiredGoods,
            //    ExpiryGoods = model.ExpiryGoods,
            //    PharmacyCode= model.PharmacyCode,
            //    PharmacyId = model.PharmacyID,
            //    DistributorId = model.DistributorID,
            //    Products = model.Products,
            //    OrderDate = DateTime.Now, 
            //    AgentId = model.AgentID,

            //};
            Insert(model);
        }

    }
}
