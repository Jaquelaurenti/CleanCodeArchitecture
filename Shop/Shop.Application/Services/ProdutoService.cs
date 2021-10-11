using Shop.Application.Interfaces;
using Shop.Application.ViewModels;
using Shop.Domain.Interfaces;
using System;

namespace Shop.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        IProdutoRepository _produtoRepository;

        // ESTÁ CHAMANDO A INTERFACE DE REPOSITORY QUE ESTÁ NA CAMADA DE DOMAIN
        // QUE A DOMAIN É REFERENCIA NA CAMADA DE DATA (QUE ACESSA O BANCO)
        // NOTE QUE ESSA INJEÇÃO DE DEPENDENCIA LEMBRA DO ULTIMO PRINCIPIO APRESENTADO DO SOLID
        // AS DEPENDENCIAS DA CLEAN ARCH ESTÃO SENDO RESPEITADA, POIS É A INTERFACE DE REPOSITORY QUE FAZ O ACESSO AO BD P
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public ProdutoViewModel GetProdutos()
        {

            var response = _produtoRepository.GetProdutos();

            return new ProdutoViewModel()
            {
                Produtos = response,
            };
        }
    }
}
