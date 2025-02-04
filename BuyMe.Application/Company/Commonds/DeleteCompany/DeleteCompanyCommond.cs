﻿using BuyMe.Application.Common.Behaviour;
using BuyMe.Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BuyMe.Application.Company.Commonds.DeleteCompany
{
    public class DeleteCompanyCommond : IRequest<Unit>
    {
        public int CompanyId { get; set; }

        public class DeleteCompanyCommondHandler : IRequestHandler<DeleteCompanyCommond, Unit>
        {
            private readonly IBuyMeDbContext _context;

            public DeleteCompanyCommondHandler(IBuyMeDbContext context)
            {
                this._context = context;
            }

            public async Task<Unit> Handle(DeleteCompanyCommond request, CancellationToken cancellationToken)
            {
                var company = await _context.Companies.FindAsync(request.CompanyId);
                Guard.Against.Null(company, request.CompanyId);
                _context.Companies.Remove(company);
                await _context.SaveChangesAsync(cancellationToken);
                return Unit.Value;
            }
        }
    }
}