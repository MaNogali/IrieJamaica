using System.ComponentModel.DataAnnotations;

namespace ProjetoJamaica.Models
{
    public class Cliente
    {
        [Display(Name = "Código", Description = "Código.")]
        public int Id { get; set; }

        [Display(Name = "Nome completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "O nome completo é obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = " O Email não é válido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "O senha é obrigatório")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 10 caracteres")]
        public string Senha { get; set; }

        [Display(Name = "Situação")]
        [Required(ErrorMessage = "O Situação é obrigatório")]
        public string Situacao { get; set; }
    }
}
