using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWFilmes.Domain
{
    //Definindo o nome da tabela no banco de dados
    [Table("Categoria")]
    public class Categoria
    {
        //dizendo pro .NET que esse atributo será uma chave primária (data anotation sempre vem em cima da propriedade/classe)
        //o Required é para dizer que o atributo é obrigatório
        //o MaxLength define o tamanho máximo aceito pelo campo

        [Key]
        [Required(ErrorMessage = "O Código deve ser informado.")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "A Descrição deve ser informada.")]
        [MaxLength(100, ErrorMessage = "A Descrição deve conter no máximo 100 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A Cor deve ser informada")]
        [MaxLength(50, ErrorMessage = "A Cor deve conter no máximo 50 caracteres.")]
        public string Cor { get; set; }
    }
}
