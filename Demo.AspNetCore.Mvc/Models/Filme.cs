using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.AspNetCore.Mvc.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter entre 3 ou 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo data é obrigatório")]
        [Display(Name = "Data de lançamento")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "O campo genero é obrigatório")]
        [StringLength(30, ErrorMessage = "Apenas 30 caracteres são permitidos")]
        public string Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]
        [Required(ErrorMessage = "Preencha o campo Valor")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor{ get; set; }

        [Required(ErrorMessage = "Preencha o campo avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; }
    }
}
