using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using spoc1.Data;
using spoc1.Logic;
using spoc1.Logic.Models;
using Spoc1.Logic.Models;
using Spoc1.Service;
using Spoc1Api.Attributes;
using System.Collections.Generic;

namespace Spoc1Api.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    [ApiKeyAuth]
    public class OrderController : ControllerBase
    {
        UnitOfWork unitOfWork;
        private readonly IService service;
        public OrderController(Context context, IMapper mapper)
        {
            unitOfWork = new UnitOfWork(context);
            service = new Service(unitOfWork, mapper);
        }


        [HttpGet]
        public OrderViewDTO GetOrder(int Orderid)
        {
            return service.GetOrder(Orderid);
        }

        //[HttpGet]
        //public ProductDTO test()
        //{
        //    return service.test();
        //}


        [HttpGet]
        public IEnumerable<OrderAgentDTO> GetOrdersAgent(int AgentId)
        {
            return service.GetOrdersAgent(AgentId);
        }


        [HttpGet]
        public IEnumerable<OrderManagerDTO> GetOrdersManager(int ManagerId)
        {
            return service.GetOrdersManager(ManagerId);
        }


        [HttpGet]
        public IEnumerable<OrderManagerDTO> GetOrdersManagerByAgentName(string AgentName, int ManagerId)
        {
            return service.GetOrdersManagerByAgentName(AgentName, ManagerId);
        }


        [HttpGet]
        public IEnumerable<OrderAdminDTO> GetOrdersAdmin(int AdminId)
        {
            return service.GetOrdersAdmin(AdminId);
        }


        [HttpGet]
        public IEnumerable<OrderAdminDTO> GetOrdersAdminByAgentName(string AgentName, int AdminId)
        {
            return service.GetOrdersAdminByAgentName(AgentName, AdminId);
        }


        [HttpPost]
        public ResultDTO AddOrder(AddOrderDTO model)
        {
            return service.AddOrder(model);
        }


        [HttpGet]
        public IEnumerable<PharmacyDTO> GetPharmacies(int AgentId)
        {
            return service.GetPharmacies(AgentId);
        }


        [HttpPost]
        public void AddPharmacy(PharmacyDTO pharmacy)
        {
            service.AddPharmacy(pharmacy);
        }


        [HttpGet]
        public IEnumerable<DistributorDTO> GetDistributors(int AgentId)
        {
            return service.GetDistributors(AgentId);
        }


        [HttpPost]
        public void AddDistributor(DistributorDTO distributor)
        {
            service.AddDistributor(distributor);
        }


        [HttpGet]
        public IEnumerable<ProductDTO> GetProducts()
        {
            return service.GetProducts();
        }


        [HttpPost]
        public void AddNewProduct(ProductDTO product)
        {
            service.AddNewProduct(product);
        }


    }
}
