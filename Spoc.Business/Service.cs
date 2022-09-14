using AutoMapper;
using Microsoft.Extensions.Configuration;
using spoc1.Data;
using spoc1.Logic;
using spoc1.Logic.Models;
using Spoc1.Data;
using Spoc1.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Spoc1.Service
{
    public class Service : IService
    {
        private UnitOfWork unitofwork;
        
        private readonly IMapper mapper;
        IConfiguration iconfiguration;

        public Service(UnitOfWork unitOfWork, IMapper mapper, IConfiguration iconfiguration)
        {
            this.unitofwork = unitOfWork;
            this.mapper = mapper;
            this.iconfiguration = iconfiguration;
        }


        public ResultDTO LoginAgent(LoginDTO log)
        {
            var model = unitofwork.Agent.Get(log.Email);
            if (model != null)
            {
                if (model.Password == log.Password)
                {
                    return new ResultDTO { IsSuccess = true, Token = iconfiguration["ApiKey"], Data = model.Id };
                }
                else
                {
                    return new ResultDTO { IsSuccess = false };
                }
            }
            else
            {
                return new ResultDTO { IsSuccess = false };
            }
        }

        public ResultDTO LoginManager(LoginDTO log)
        {
            var model = unitofwork.Manager.Get(log.Email);
            if (model != null)
            {
                if (model.Password == log.Password)
                {
                    return new ResultDTO { IsSuccess = true, Token = iconfiguration["ApiKey"], Data = model.Id };
                }
                else
                {
                    return new ResultDTO { IsSuccess = false };
                }
            }
            else
            {
                return new ResultDTO { IsSuccess = false };
            }
        }

        public ResultDTO LoginAdmin(LoginDTO log)
        {
            var model = unitofwork.Admin.Get(log.Email);
            if (model != null)
            {
                if (model.Password == log.Password)
                {
                    return new ResultDTO { IsSuccess = true, Token = iconfiguration["ApiKey"], Data = model.Id };
                }
                else
                {
                    return new ResultDTO { IsSuccess = false };
                }
            }
            else
            {
                return new ResultDTO { IsSuccess = false };
            }
        }

        public ResultDTO RegisterAgent(AgentDTO agent)
        {
            var res = mapper.Map<Agent>(agent);
            unitofwork.Agent.Add(res);
            unitofwork.Commit();
            return new ResultDTO { IsSuccess = true, };
        }

        public ResultDTO RegisterManager(ManagerDTO manager)
        {
            var res = mapper.Map<Manager>(manager);
            unitofwork.Manager.Add(res);
            unitofwork.Commit();
            return new ResultDTO { IsSuccess = true, };
        }

        public ResultDTO RegisterAdmin(AdminDTO admin)
        {
            var res = mapper.Map<Admin>(admin);
            unitofwork.Admin.Add(res);           
            unitofwork.Commit();
            return new ResultDTO { IsSuccess = true, };
        }

        public IEnumerable<AgentDTO> GetAgents()
        {
            var model = unitofwork.Agent.Get();

            var res = mapper.Map<IEnumerable<Agent>, IEnumerable<AgentDTO>>(model);

            return res;
        }

        public IEnumerable<ManagerDTO> GetManagers()
        {
            var model = unitofwork.Manager.Get();

            var res = mapper.Map<IEnumerable<ManagerDTO>>(model);

            return res;
        }

        public IEnumerable<AdminDTO> GetAdmins()
        {
            var model = unitofwork.Admin.Get();

            var res = mapper.Map<IEnumerable<AdminDTO>>(model);

            return res;
        }

        public IEnumerable<OrderAgentDTO> GetOrdersAgent(int AgentId)
        {
            var model = unitofwork.Order.GetOrdersAgent(AgentId);
            var res = mapper.Map<IEnumerable<OrderAgentDTO>>(model);
            return res;
        }

        public IEnumerable<OrderManagerDTO> GetOrdersManager(int ManagerId)
        {
            var model = unitofwork.Order.GetOrdersManager(ManagerId);
            var res = mapper.Map<IEnumerable<OrderManagerDTO>>(model);
            return res;
        }

        public IEnumerable<OrderManagerDTO> GetOrdersManagerByAgentName(string AgentName, int ManagerId)
        {
            var model = unitofwork.Order.GetOrdersManagerByAgentName(AgentName, ManagerId);
            var res = mapper.Map<IEnumerable<OrderManagerDTO>>(model);
            return res;
        }

        public IEnumerable<OrderAdminDTO> GetOrdersAdmin(int AdminId)
        {
            var model = unitofwork.Order.GetOrdersAdmin(AdminId);
            var res = mapper.Map<IEnumerable<OrderAdminDTO>>(model);
            return res;
        }

        public IEnumerable<OrderAdminDTO> GetOrdersAdminByAgentName(string AgentName, int AdminId)
        {
            var model = unitofwork.Order.GetOrdersAdminByAgentName(AgentName, AdminId);
            var res = mapper.Map<IEnumerable<OrderAdminDTO>>(model);
            return res;
        }

        public ResultDTO AddOrder(AddOrderDTO model)
        {
            var product = mapper.Map<IEnumerable<ProductOrderInputDTO>, IEnumerable<ProductOrder>>(model.Products);
            var res = mapper.Map<Order>(model);
            res.Products = (ICollection<ProductOrder>)product;
            res.OrderDate = DateTime.Now;
            unitofwork.Order.CreateOrder(res);
            unitofwork.Commit();
            return new ResultDTO { IsSuccess = true };
        }

        public OrderViewDTO GetOrder(int Orderid)
        {
            var model = unitofwork.Order.GetOrder(Orderid);
            var res = mapper.Map<OrderViewDTO>(model);
            var products = mapper.Map<IEnumerable<ProductOrder>,IEnumerable<ProductOrderDTO>>(model.Products);
            res.Products = products;
            return res;
        }

        public IEnumerable<PharmacyDTO> GetPharmacies(int AgentId)
        {
            var model = unitofwork.Pharmacy.Get(AgentId);
            var res = mapper.Map<IEnumerable<Pharmacy>, IEnumerable<PharmacyDTO>>(model);
            return res;
        }

        public void AddPharmacy(PharmacyDTO pharmacy)
        {
            var model = mapper.Map<Pharmacy>(pharmacy);
            unitofwork.Pharmacy.Add(model);
            unitofwork.Commit();
        }

        public IEnumerable<DistributorDTO> GetDistributors(int AgentId)
        {
            var model = unitofwork.Distributor.Get(AgentId);
            var res = mapper.Map<IEnumerable<Distributor>, IEnumerable<DistributorDTO>>(model);
            return res;
        }

        public void AddDistributor(DistributorDTO distributor)
        {
            var model = mapper.Map<Distributor>(distributor);
            unitofwork.Distributor.Add(model);
            unitofwork.Commit();
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            var model = unitofwork.Product.Get();
            var products = mapper.Map<IEnumerable<Product>, IEnumerable<ProductDTO>>(model);
            return products;
        }

        public void AddNewProduct(ProductDTO product)
        {
            var model = mapper.Map<Product>(product);
            unitofwork.Product.AddNew(model);
            unitofwork.Commit();
        }

        //Product p = new Product()
        //{
        //     Id = 1,
        //     Name = "greg",
        //     Description = "fwfew"
        //};
        //public ProductDTO test()
        //{
        //    var res = mapper.Map<ProductDTO>(p);
        //    return res;
        //}

    }

    public interface IService
    {
        ResultDTO LoginAgent(LoginDTO log);

        ResultDTO LoginManager(LoginDTO log);

        ResultDTO LoginAdmin(LoginDTO log);

        ResultDTO RegisterAgent(AgentDTO agent);

        ResultDTO RegisterManager(ManagerDTO manager);

        ResultDTO RegisterAdmin(AdminDTO admin);

        IEnumerable<AgentDTO> GetAgents();

        IEnumerable<ManagerDTO> GetManagers();
        
        IEnumerable<AdminDTO> GetAdmins();
        
        IEnumerable<OrderAgentDTO> GetOrdersAgent(int AgentId);
        
        IEnumerable<OrderManagerDTO> GetOrdersManager(int ManagerId);

        IEnumerable<OrderManagerDTO> GetOrdersManagerByAgentName(string AgentName,int ManagerId);

        IEnumerable<OrderAdminDTO> GetOrdersAdmin(int AdminId);

        IEnumerable<OrderAdminDTO> GetOrdersAdminByAgentName(string AgentName, int AdminId);

        ResultDTO AddOrder(AddOrderDTO model);

        OrderViewDTO GetOrder(int Orderid);
        
        IEnumerable<PharmacyDTO> GetPharmacies(int AgentId);
        
        void AddPharmacy(PharmacyDTO pharmacy);
        
        IEnumerable<DistributorDTO> GetDistributors(int AgentId);
        
        void AddDistributor(DistributorDTO distributor);
        
        IEnumerable<ProductDTO> GetProducts();

        void AddNewProduct(ProductDTO product);

        //ProductDTO test();

    }

}
 