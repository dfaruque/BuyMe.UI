﻿using AutoMapper;
using BuyMe.Application.Branch.Queries;
using BuyMe.Application.Common.Mapping;
using BuyMe.Application.Company.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMe.Application.WarehouseINV.Queries
{
    public class WarhouseDto:IMapFrom
    {
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public int? BranchId { get; set; }
        public string BranchName { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Warehouse, WarhouseDto>()
                .ForMember(a => a.BranchName, a => a.MapFrom(p => p.Branch.BranchName));
        }
    }
}
