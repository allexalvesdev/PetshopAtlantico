using System;

namespace PetshopAtlantico.Entities
{
    public class Consulta : Entity
    {

        public Consulta()
        {
            DataRegistro = DateTime.Now;
        }

        public DateTime DataRegistro { get; set; }
        public ETipoTratamento TipoTratamento { get; set; }
        public string Motivo { get; set; }


        /*RL EF CORE*/
        public virtual Cliente Cliente { get; set; }
        public virtual Guid ClienteId { get; set; }
        public virtual Animal Animal { get; set; }
        public virtual Guid AnimalId { get; set; }
        public virtual Alojamento Alojamento { get; set; }
        public virtual Guid AlojamentoId { get; set; }
    }
}
