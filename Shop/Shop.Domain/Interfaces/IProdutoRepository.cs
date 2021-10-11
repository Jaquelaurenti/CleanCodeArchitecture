using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetProdutos();
    }
}
