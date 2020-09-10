﻿using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using MediatR;
using Rems.Application.Common.Extensions;
using Rems.Application.Common.Interfaces;

namespace Rems.Application.CQRS
{
    public class InsertTableCommand : IRequest<Unit>
    {
        public DataTable Table { get; set; }

        public Type Type { get; set; }
    }

    public class InsertTableCommandHandler : IRequestHandler<InsertTableCommand, Unit>
    {
        private readonly IRemsDbContext _context;

        public InsertTableCommandHandler(IRemsDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(InsertTableCommand request, CancellationToken cancellationToken)
        {
            var infos = request.Table.Columns.Cast<DataColumn>()
                .Select(c => c.FindInfo(request.Type))
                .Where(c => c != null)
                .ToArray();

            foreach (DataRow row in request.Table.Rows)
            {
                var entity = row.ToEntity(_context, request.Type, infos);
                _context.Add(entity);

                EventManager.InvokeProgressIncremented(null, EventArgs.Empty);
            }

            _context.SaveChanges();

            return Unit.Value;
        }
    }
}