using System;

namespace PetshopAtlantico.Entities
{
    public class Animal : Entity
    {
        public string Nome { get; set; }
        public ETipoEspecie TipoEspecie { get; set; }
        public ETipoSexo TipoSexo { get; set; }
        public ETipoPorte TipoPorte { get; set; }

        /*RL EF CORE*/
        public Cliente Cliente { get; set; }
        public Guid ClienteId { get; set; }
    }
}
