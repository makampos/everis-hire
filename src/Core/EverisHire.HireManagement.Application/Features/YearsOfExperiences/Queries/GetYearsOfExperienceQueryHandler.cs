using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.YearsOfExperiences.Queries
{
    public class GetYearsOfExperienceQueryHandler :
        IRequestHandler<GetYearsOfExperienceListQuery,
        List<YearsOfExperienceListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<YearsOfExperience> _yearsOfExperienceRepository;
        public GetYearsOfExperienceQueryHandler(IMapper mapper, IAsyncRepository<YearsOfExperience> yearsOfExperienceRepository)
        {
            _mapper = mapper;
            _yearsOfExperienceRepository = yearsOfExperienceRepository;
        }
        public async Task<List<YearsOfExperienceListVm>> Handle(
            GetYearsOfExperienceListQuery request,
            CancellationToken cancellationToken)
        {
            var allYearsOfExperience = (await _yearsOfExperienceRepository.ListAllAsync());
            return _mapper.Map<List<YearsOfExperienceListVm>>(allYearsOfExperience);
        }
    }
}