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
                .NotEmpty().WithMessage("Nome completo não pode estar vazio")
                .Length(10, 250).WithMessage("Usuario deve conter entre 10 e 250 caracteres")
                .Must(nome => nome.Split(' ').Length >= 2).WithMessage("Nome completo deve conter pelo menos o primeiro nome e um sobrenome");

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("Email não pode estar vazio")
                .NotNull().WithMessage("Email não pode ser nulo")
                .EmailAddress().WithMessage("Formato de e-mail inválido");

            RuleFor(p => p.Usuario)
                .NotEmpty().WithMessage("Usuario não pode estar vazio")
                .NotNull().WithMessage("Usuario não pode ser nulo")
                .Length(6, 250).WithMessage("Usuario deve conter entre 2 e 250 caracteres");

            RuleFor(p => p.Senha)
                .NotEmpty().WithMessage("Senha não pode estar vazia")
                .MinimumLength(8).WithMessage("Senha deve ter no mínimo 8 caracteres")
                .MaximumLength(250).WithMessage("Senha deve ter no máximo 250 caracteres");
                //.Matches("[A-Z]").WithMessage("Senha deve conter pelo menos uma letra maiúscula")
                //.Matches("[a-z]").WithMessage("Senha deve conter pelo menos uma letra minúscula")
                //.Matches("[0-9]").WithMessage("Senha deve conter pelo menos um algarismo")
                //.Matches("[^a-zA-Z0-9]").WithMessage("Senha deve conter pelo menos um caractere especial");

            RuleFor(p => p.TipoPessoa_ID)
			    .NotNull().WithMessage("Tipo Pessoa não pode ser nulo");
        }
    }
}