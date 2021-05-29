using PetshopAtlantico.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetshopAtlantico.ViewModels
{
    public class AlojamentoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Nome do Alojamento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [DisplayName("Status do Alojamento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public ETipoStatus TipoStatus { get; set; }
    }
}
