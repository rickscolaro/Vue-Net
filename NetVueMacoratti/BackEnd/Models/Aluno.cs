using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class Aluno
    {
        [Key]
        public int AlunoId { get; set; }

        [Required]
        [StringLength(80)]
        public string Nome { get; set; }

        [Required]
        //[EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public int Idade { get; set; }
    }
}