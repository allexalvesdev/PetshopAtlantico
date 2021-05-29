using PetshopAtlantico.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetshopAtlantico.ViewModels
{
    public class ConsultaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Data do Cadastro")]
        public DateTime DataRegistro { get; set; }

        [DisplayName("Status de Saúde")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public ETipoTratamento TipoTratamento { get; set; }

        [DisplayName("Motivo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Motivo { get; set; }

        [DisplayName("Dono")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public virtual Guid ClienteId { get; set; }

        [DisplayName("Animal")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public virtual Guid AnimalId { get; set; }

        [DisplayName("Alojamento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public virtual Guid AlojamentoId { get; set; }

        /*RL EF CORE*/
        public virtual Cliente Cliente { get; set; }     
        public virtual Animal Animal { get; set; }     
        public virtual Alojamento Alojamento { get; set; }
        
    }
}
