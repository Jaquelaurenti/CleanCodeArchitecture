using Shop.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Application.Interfaces
{
    public interface IProdutoService
    {
        ProdutoViewModel GetProdutos();
    }
}
