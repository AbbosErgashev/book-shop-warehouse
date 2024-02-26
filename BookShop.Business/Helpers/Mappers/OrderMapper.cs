using AutoMapper;
using BookShop.Business.Models.OrderModel;
using BookShop.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Business.Helpers.Mappers
{
    public class OrderMapper : Profile
    {
        public OrderMapper()
        {
            CreateMap<Order, CreateOrderModel>().ReverseMap();
            CreateMap<Order, ReadOrderModel>().ReverseMap();
            CreateMap<Order, UpdateOrderModel>().ReverseMap();
        }
    }
}
