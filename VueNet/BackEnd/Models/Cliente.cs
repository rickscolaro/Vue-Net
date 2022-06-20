using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models {

    
    public class Cliente {

        [Key]
        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }


    }
}