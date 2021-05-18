using EverisHire.HireManagement.Application.Responses;

namespace EverisHire.HireManagement.Application.Features.Projects.Commands.CreateProject
{
    public class CreateProjectCommandResponse : BaseResponse
    {
        public CreateProjectCommandResponse() : base()
        {
            
        }

        public CreateProjectDto Project { get; set; }
    }
}