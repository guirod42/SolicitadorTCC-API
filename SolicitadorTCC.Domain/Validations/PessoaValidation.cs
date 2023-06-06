using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace SolicitadorTCC.Domain.Validations
{
    public class PessoaValidation : AbstractValidator<Pessoa>
    {
		public PessoaValidation()
		{
            RuleFor(p => p.Nome)
				.NotEmpty()
					.WithMessage("Nome não pode estar vazio")
				.NotNull()
					.WithMessage("Nome não pode ser nulo")
				.Length(2, 250)
					.WithMessage("Nome deve conter entre 2 e 250 caracteres");

		    RuleFor(p => p.Email)
                .NotEmpty()
                    .WithMessage("Email não pode estar vazio")
                .NotNull()
                    .WithMessage("Email não pode ser nulo")
                .Length(2, 250)
                    .WithMessage("Email deve conter entre 2 e 250 caracteres");

            RuleFor(p => p.Usuario)
                .NotEmpty()
                    .WithMessage("Usuario não pode estar vazio")
                .NotNull()
                    .WithMessage("Usuario não pode ser nulo")
                .Length(2, 250)
                    .WithMessage("Usuario deve conter entre 2 e 250 caracteres");


            RuleFor(p => p.Senha)
			    .NotNull()
				    .WithMessage("Senha não pode ser nula");

            RuleFor(p => p.TipoPessoa_ID)
			    .NotNull()
				    .WithMessage("Tipo Pessoa não pode ser nulo");
        }
    }
}