using AutoMapper;
using spoc1.Data;
using spoc1.Logic.Models;
using Spoc1.Data;
using Spoc1.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spoc1.Service
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Product, ProductDTO>();

            CreateMap<Product, ProductDTO>().ReverseMap();

            CreateMap<Pharmacy, PharmacyDTO>();

            CreateMap<Pharmacy, PharmacyDTO>().ReverseMap();

            CreateMap<Distributor, DistributorDTO>();

            CreateMap<Distributor, DistributorDTO>().ReverseMap();

            CreateMap<Admin, AdminDTO>();

            CreateMap<Admin, AdminDTO>().ReverseMap();

            CreateMap<Agent, AgentDTO>();

            CreateMap<Agent, AgentDTO>().ReverseMap();

            CreateMap<Manager, ManagerDTO>();

            CreateMap<Manager, ManagerDTO>().ReverseMap();

            CreateMap<Order, OrderAgentDTO>().ForMember(dest => dest.PharmacyName, src => src.MapFrom(src => src.Pharmacy.Name));

            CreateMap<Order, OrderAgentDTO>().ForMember(dest => dest.PharmacyName, src => src.MapFrom(src => src.Pharmacy.Name)).ReverseMap();

            CreateMap<Order, OrderDTO>().ForMember(dest => dest.Id, src => src.MapFrom(src => src.Id))
                .ForMember(dest => dest.AgentName, src => src.MapFrom(src => src.Agent.Name))
                .ForMember(dest => dest.PharmacyName, src => src.MapFrom(src => src.Pharmacy.Name))
                .ForMember(dest => dest.DistributorName, src => src.MapFrom(src => src.Distributor.Name));

            CreateMap<Order, OrderManagerDTO>().ForMember(dest => dest.PharmacyName, src => src.MapFrom(src => src.Pharmacy.Name))
                .ForMember(dest => dest.AgentName, src => src.MapFrom(src => src.Agent.Name));

            CreateMap<Order, OrderAdminDTO>().ForMember(dest => dest.PharmacyName, src => src.MapFrom(src => src.Pharmacy.Name))
                .ForMember(dest => dest.AgentName, src => src.MapFrom(src => src.Agent.Name));

            CreateMap<Order, OrderViewDTO>().ForMember(dest => dest.AgentName, src => src.MapFrom(s => s.Agent.Name))
                .ForMember(dest => dest.DistributorName, src => src.MapFrom(s => s.Distributor.Name))
                .ForMember(dest => dest.PharmacyName, src => src.MapFrom(s => s.Pharmacy.Name))
                .ForMember(dest => dest.ManagerName, src => src.MapFrom(s => s.Agent.Manager.Name));

            CreateMap<ProductOrder, ProductOrderDTO>().ForMember(dest => dest.Name, src => src.MapFrom(src => src.Product.Name))
                .ForMember(dest => dest.ExpiryDate, src => src.MapFrom(src => src.Expirydate))
                .ForMember(dest => dest.Quantity, src => src.MapFrom(src => src.Quantity));

            CreateMap<ProductOrderInputDTO, ProductOrder>().ForMember(dest => dest.ProductId, src => src.MapFrom(src => src.ProductId));

            CreateMap<AddOrderDTO, Order>().ForMember(dest => dest.AgentId, src => src.MapFrom(src => src.AgentID))
                .ForMember(dest => dest.PharmacyId, src => src.MapFrom(src => src.PharmacyID))
                .ForMember(dest => dest.DistributorId, src => src.MapFrom(src => src.DistributorID))
                .ForMember(dest => dest.Products, src => src.MapFrom(s => s.Products));
                

           
        }
    }
}
