using EverisHire.HireManagement.Application.Responses;

namespace EverisHire.HireManagement.Application.Features.Categories.Commands
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryCommandResponse() : base()
        {
            
        }
         public CreateCategoryDto Category { get; set; }
    }
   
}