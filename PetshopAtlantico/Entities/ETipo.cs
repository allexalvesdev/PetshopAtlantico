using System.ComponentModel.DataAnnotations;

namespace PetshopAtlantico.Entities
{

    //Caracteristica para o Animal
    public enum ETipoEspecie
    {
        Canina = 1,
        Felina = 2
    }

    //Caracteristica para o Animal
    public enum ETipoSexo
    {
        [Display(Name = "Macho")]
        Macho = 1,
        [Display(Name = "Fêmea")]
        Femea = 2
    }

    //Caracteristica para o Animal
    public enum ETipoPorte
    {
        [Display(Name = "Pequeno")]
        Pequeno = 1,
        [Display(Name = "Médio")]
        Medio = 2,
        [Display(Name = "Grande")]
        Grande = 3
    }

    //Status para o Animal dentro da Consulta
    public enum ETipoTratamento
    {
        [Display(Name = "Em Tratamento")]
        EmTratamento = 1,
        [Display(Name = "Recuperando")]
        Recuperando = 2,
        [Display(Name = "Recuperado")]
        Recuperado = 3
    }

    //Status para o Alojamento
    public enum ETipoStatus
    {
        [Display(Name = "Ocupado")]
        Ocupado = 1,
        [Display(Name = "Livre")]
        Livre = 2,
        [Display(Name = "Esperando o Dono")]
        EsperandoDono = 3
    }
}
