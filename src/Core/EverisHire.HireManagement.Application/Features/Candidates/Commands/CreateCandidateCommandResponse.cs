using EverisHire.HireManagement.Application.Responses;

namespace EverisHire.HireManagement.Application.Features.Candidates.Commands
{
    public class CreateCandidateCommandResponse : BaseResponse
    {
        public CreateCandidateCommandResponse() : base()
        {
            
        }
        
        // The property will be returned by request
        public CreateCandidateDto Candidate { get; set; }

    }
}