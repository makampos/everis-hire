using EverisHire.HireManagement.Application.Responses;

namespace EverisHire.HireManagement.Application.Features.Jobs.Commands.CreateJob
{
    public class CreateJobCommandResponse : BaseResponse
    {
        public CreateJobCommandResponse() : base()
        {
        }

        public CreateJobDto Job { get; set; }
    }
}