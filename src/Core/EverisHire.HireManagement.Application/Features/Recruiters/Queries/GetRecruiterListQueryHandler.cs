

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Recruiters.Queries
{
    public class GetRecruiterListQueryHandler : 
        IRequestHandler<GetRecruitersListQuery, List<RecruiterListVm>>
    {
        private readonly IAsyncRepository<Recruiter> _recruiterRepository;
        private readonly IMapper _mapper;

        public GetRecruiterListQueryHandler(
            IMapper mapper,
            IAsyncRepository<Recruiter> recruiterRepository)
        {
            _mapper = mapper;
            _recruiterRepository = recruiterRepository;
        }

        public async Task<List<RecruiterListVm>> Handle(
            GetRecruitersListQuery request,
            CancellationToken cancellationToken)
        {
            var allRecruiters = (await _recruiterRepository.ListAllAsync());
            return _mapper.Map<List<RecruiterListVm>>(allRecruiters);
        }

       
    }
}