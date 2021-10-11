using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
// Camada que representará o que será apresentado pelo usuário através da useinterface
namespace Shop.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }

    }
}
