using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Business.ValidationRules.FluentValidation
{
    public class TaskValidator:AbstractValidator<Entities.Concrete.Task>
    {
        public TaskValidator()
        {
            RuleFor(t => t.TaskTitle).NotEmpty();
            RuleFor(t=>t.TaskTitle).MinimumLength(3);
            //RuleFor(t => t.TaskDescription).Must(StartWithNumber).WithMessage("sayı ile başlama");
        }

        private bool StartWithNumber(string arg)
        {
            return arg.StartsWith("0");
        }
    }
}
