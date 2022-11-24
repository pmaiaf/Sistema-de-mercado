using System;
using System.Collections.Generic;

namespace Atividade___1
{
    public class Pedido
    {
        private List<ItemPedido> ListaPedido = new List<ItemPedido>();

        public void AddPedido(ItemPedido ip)
        {
            ListaPedido.Add(ip);
        }

       

        public double TotalizarPedido()
        {
            double total = 0;
            foreach (ItemPedido todospedidos in ListaPedido)
            {
            string desc = todospedidos.descricao;
            double qtd = todospedidos.quantidade;
            double valor = todospedidos.valor;

            Console.WriteLine("O item escolhido foi: " + desc + " a quantidade foi: " + qtd + "e o valor foi: " + valor);
             total = total + (todospedidos.valor * todospedidos.quantidade);
            }
             Console.Write("O valor total do pedido é:R$");
             return total;
        }
    }
}
