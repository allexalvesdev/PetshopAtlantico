using PetshopAtlantico.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetshopAtlantico.ViewModels
{
    public class AnimalViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Nome do Animal")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [DisplayName("Espécie")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public ETipoEspecie TipoEspecie { get; set; }

        [DisplayName("Sexo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public ETipoSexo TipoSexo { get; set; }

        [DisplayName("Porte")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public ETipoPorte TipoPorte { get; set; }

        [DisplayName("Dono")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid ClienteId { get; set; }

        /*RL EF CORE*/
        public Cliente Cliente { get; set; }

    }
}
