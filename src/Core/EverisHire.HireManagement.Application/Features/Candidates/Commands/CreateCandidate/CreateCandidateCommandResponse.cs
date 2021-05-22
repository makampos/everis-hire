using EverisHire.HireManagement.Application.Responses;

namespace EverisHire.HireManagement.Application.Features.Candidates.Commands
{
    public class CreateCandidateCommandResponse : BaseResponse
    {
        public CreateCandidateCommandResponse() : base()
        {
            
        }               
        public CreateCandidateDto Candidate { get; set; }
    }
}