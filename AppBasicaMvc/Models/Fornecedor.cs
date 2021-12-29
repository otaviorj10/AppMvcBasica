﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppBasicaMvc.Models
{
    public class Fornecedor : Entity
    {
        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }

        /*1 fornecedor tem um endereco*/
        public Endereco Endereco { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        /* entity releations -  1 Fornecedor tem muitos Produtos*/
        public IEnumerable<Produto> produtos { get; set; }
    }
}