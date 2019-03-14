using FluentValidation;
using NC.OS.API.Models;
using NC.OS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NC.OS.API.Infrastructure.Validators
{
    public class AccountViewModelValidators
    {
    }

    public class LoginViewModelValidator : AbstractValidator<LoginModel>
    {
        public LoginViewModelValidator()
        {
            RuleFor(r => r.Username).NotEmpty()
                .WithMessage("Invalid username");

            RuleFor(r => r.Password).NotEmpty()
                .WithMessage("Invalid password");
        }
    }

    public class OrderViewModelValidator : AbstractValidator<OrderModel>
    {
        public OrderViewModelValidator()
        {
            RuleFor(r => r.Sender.Name).NotEmpty()
                .WithMessage("Invalid Sender Name");

            RuleFor(r => r.Sender.Phone).NotEmpty()
                .WithMessage("Invalid Sender Phone");

            RuleFor(r => r.Receiver.Name).NotEmpty()
                .WithMessage("Invalid Receiver Name");

            RuleFor(r => r.Receiver.Phone).NotEmpty()
                .WithMessage("Invalid Sender Phone");

            RuleFor(r => r.Receiver.Address).NotEmpty()
               .WithMessage("Invalid Address Phone");

            RuleFor(r => r.Package.Weight).NotEmpty()
              .WithMessage("Invalid Package Weight");

            RuleFor(r => r.Package.From).NotEmpty()
              .WithMessage("Invalid Package From");

            RuleFor(r => r.Package.To).NotEmpty()
             .WithMessage("Invalid Package To");

            RuleFor(r => r.Package.Height).NotEmpty()
           .WithMessage("Invalid Package Height");

            RuleFor(r => r.Package.Depth).NotEmpty()
          .WithMessage("Invalid Package Depth");

            RuleFor(r => r.Package.Breadth).NotEmpty()
         .WithMessage("Invalid Package Breadth");
        }
    }
}