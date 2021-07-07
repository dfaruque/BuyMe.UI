﻿using AutoMapper;
using BuyMe.Application.Branch.Queries;
using BuyMe.Application.Category.Queries;
using BuyMe.Application.Common.Mapping;
using BuyMe.Application.Company.Queries;
using BuyMe.Application.Currency.Queries;
using BuyMe.Application.Customer.Queries.GetCustomers;
using BuyMe.Application.SalesOrderLine.Queries;
using BuyMe.Application.SalesType.Queries;
using BuyMe.Application.UnitOfMeasure.Queries;
using BuyMe.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMe.Application.SalesOrder.Queries
{
    public class SalesOrderDto : IMapFrom
    {
       
        public long SalesOrderId { get; set; }
        public string SalesOrderName { get; set; }
        public int? BranchId { get; set; }
        public string BranchName { get; set; }
        public int? CurrencyId { get; set; }
        public int? SalesTypeId { get; set; }
        public string SalesTypeName { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public double Amount { get; set; }
        public double SubTotal { get; set; }
        public double Discount { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }
        public double Freight { get; set; }
        public string Remarks { get; set; }
        public string CurrencyCode { get; set; }
       
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.SalesOrder, SalesOrderDto>()
                .ForMember(a => a.BranchName, a => a.MapFrom(p => p.Branch.BranchName))
                 .ForMember(a => a.CustomerName, a => a.MapFrom(p => p.Customer.CustomerName))
                 .ForMember(a => a.SalesTypeName, a => a.MapFrom(p => p.SalesType.SalesTypeName));
        }
    }
}
