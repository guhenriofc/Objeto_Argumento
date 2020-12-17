using System;
using System.Collections.Generic;

namespace Objeto_Argumento.Classes.cs
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> _carrinho = new List<Produto>();

        public void AdicionarProduto(Produto _produto){
            _carrinho.Add(_produto);
        }

        public void MostrarProduto(){
            if(_carrinho != null){
                foreach (Produto item in _carrinho)
                {
                    Console.WriteLine($"Item -> {item.Nome} Codigo -> {item.Codigo} Preco -> {item.Preco}");
                }
            }
        }

        public void RemoverProduto(Produto _produto){
            _carrinho.Remove(_produto);
        }
        
    }
}