﻿using AutoMapper;
using AutoMapper.QueryableExtensions;

using MediatR;

using Rems.Application.Common.Interfaces;

using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Rems.Application.Queries
{
    public class SowingQueryHandler : IRequestHandler<SowingQuery, SowingQueryDto>
    {
        private readonly IRemsDbContext _context;
        private readonly IMapper _mapper;

        public SowingQueryHandler(IRemsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<SowingQueryDto> Handle(SowingQuery request, CancellationToken token)
        {
            return Task.Run(() => _context.Sowings
                .Where(s => s.SowingId == request.Id)
                .ProjectTo<SowingQueryDto>(_mapper.ConfigurationProvider)
                .Single()
            );
        }
    }
}
