using FluentValidation;
namespace Model.Category.Input
{
    public class CategoryCreateInput
    { 
        public int? Parentid { get; set; }
        public string name { get; set; } 
    }
    public class CategoryCreateInputValidator : AbstractValidator<CategoryCreateInput>
    {
        public CategoryCreateInputValidator()
        {
            RuleFor(x =>x.name)
                .NotEmpty().WithMessage("Please enter Category Name");   
                     
        }
    }
}