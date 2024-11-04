using System.ComponentModel.DataAnnotations;

namespace WorkerService1.Models
{
    public enum Setor
    {
        Tecnologia,
        Saúde,
        Educação,
        Varejo,
        Outros
    }

    public class UpStyle
    {
        public int UpStyleId { get; set; }

        [Required] // Indica que o campo é obrigatório
        [StringLength(100)] // Limita o comprimento do nome
        public string Nome { get; set; }

        [Required] // Indica que o campo é obrigatório
        [StringLength(14)] // Limita o comprimento do CNPJ
        public string Cnpj { get; set; }

        [Required] // Indica que o campo é obrigatório
        public Setor Setor { get; set; } // Usa enum para definir o setor da empresa

        [Required] // Indica que o campo é obrigatório
        [StringLength(500)] // Limita o comprimento do objetivo
        public string Objetivo { get; set; }

        [Required] // Indica que o campo é obrigatório
        [StringLength(500)] // Limita o comprimento dos insights
        public string Insights { get; set; } 
    }
}