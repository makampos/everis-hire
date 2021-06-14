using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.LeadersCenters.Queries
{
    public class GetLeaderCentersListQuery: IRequest<List<LeaderCentersListVm>>
    {
        
    }
}