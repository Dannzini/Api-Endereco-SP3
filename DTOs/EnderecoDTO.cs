using System.ComponentModel.DataAnnotations;

namespace Api_Endereco.DTOs
{
    public class EnderecoDTO
    {
        public int Id { get; set; }

        [Required]
        public string Rua { get; set; } = string.Empty;

        [Required]
        public string Cidade { get; set; } = string.Empty;

        [Required]
        public string Estado { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "O CEP deve estar no formato 'XXXXX-XXX'.")]
        public string CEP { get; set; } = string.Empty;
    }
}
