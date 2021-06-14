using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Squads.Queries
{
    public class GetSquadListQuery: IRequest<List<SquadListVm>>
    {
        
    }
}