using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Communities.Queries
{
    public class GetCommunityListQuery : IRequest<List<CommunityListVm>>
    {
        
    }
}