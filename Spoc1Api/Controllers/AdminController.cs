using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using spoc1.Data;
using spoc1.Logic.Models;
using spoc1.Logic;
using System.Collections.Generic;
using Spoc1Api.Attributes;
using Microsoft.AspNetCore.Cors;
using Spoc1.Service;
using AutoMapper;

namespace Spoc1Api.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
   
    
    public class AdminController : ControllerBase
    {
        UnitOfWork unitofwork;
        private readonly IService service;
        
        public AdminController(Context context, IMapper mapper)
        {
            unitofwork = new UnitOfWork(context);
            service = new Service(unitofwork, mapper);
        }


        [HttpPost]
        public ResultDTO RegisterAgent(AgentDTO model)
        {
            return service.RegisterAgent(model);
        }

        [HttpGet]
        [ApiKeyAuth]
        public IEnumerable<AgentDTO> GetAgents()
        {
            return service.GetAgents();
        }


        [HttpPost]
        public ResultDTO LoginAgent(LoginDTO log)
        { 
            return service.LoginAgent(log);
        }

        [HttpPost]
        public ResultDTO RegisterManager(ManagerDTO model)
        {
            return service.RegisterManager(model);
        }

        [HttpGet]
        [ApiKeyAuth]
        public IEnumerable<ManagerDTO> GetManagers()
        {
            return service.GetManagers();
        }


        [HttpPost]
        public ResultDTO LoginManager(LoginDTO log)
        {
            return service.LoginManager(log);
        }

        [HttpPost]
        public ResultDTO RegisterAdmin(AdminDTO model)
        {
            return service.RegisterAdmin(model);
        }

        [HttpGet]
        [ApiKeyAuth]
        public IEnumerable<AdminDTO> GetAdmins()
        {
            return service.GetAdmins();
        }


        [HttpPost]
        
        public ResultDTO LoginAdmin(LoginDTO log)
        {
            return service.LoginAdmin(log);
        }


        
    }
}
