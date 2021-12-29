using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppBasicaMvc.Models
{
    public class Produto : Entity
    {
        /*Produto carrega a forey keign de Fornecedor */
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage ="O campo {0} é Obrigatório")]
        [StringLength(200,ErrorMessage ="O campo {0} precisa ter entre {2} e {1} caracteres" , MinimumLength =2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        /* Entity Relation 1-Produto tem 1 Fornecedor*/
        public Fornecedor Fornecedor { get; set; }


    }
}
