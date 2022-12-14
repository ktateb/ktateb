using System;
using System.ComponentModel.DataAnnotations;

using FluentValidation;
namespace Model.Comment.Inputs
{
    public class CommentCreateInput
    {
        public int CourseId { get; set; }
        [Required]
        public string CommentText { get; set; }
    }
    public class CommentCreateInputValidator : AbstractValidator<CommentCreateInput>
    {
        public CommentCreateInputValidator()
        {
            RuleFor(x => x.CommentText)
                .NotEmpty().WithMessage("Please enter the  Comment");
        }
    }
}