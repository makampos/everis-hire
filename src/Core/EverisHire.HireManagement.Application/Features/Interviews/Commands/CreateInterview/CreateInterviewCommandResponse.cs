using EverisHire.HireManagement.Application.Responses;

namespace EverisHire.HireManagement.Application.Features.Interviews.Commands.CreateInterviewCommand
{
    public class CreateInterviewCommandResponse : BaseResponse
    {
        public CreateInterviewCommandResponse() : base()
        {
            
        }

        public CreateInterviewDto Interview { get; set; }
        
    }
}