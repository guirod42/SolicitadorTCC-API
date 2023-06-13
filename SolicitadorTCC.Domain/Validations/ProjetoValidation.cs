using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitadorTCC.Domain.Validations
{
    public class ProjetoValidation : AbstractValidator<Projeto>
    {
        public ProjetoValidation()
        {
            RuleFor(p => p.Titulo)
                .NotEmpty().WithMessage("Título não pode estar vazio")
                .Length(10, 250).WithMessage("Título deve conter entre 10 e 250 caracteres");

            RuleFor(p => p.Descricao)
                .NotEmpty().WithMessage("Descricao não pode estar vazia")
                .NotNull().WithMessage("Descricao não pode ser nula")
                .Length(10, 500).WithMessage("Descricao deve conter entre 10 e 500 caracteres");
        }
    }
}
