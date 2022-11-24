using System;
using System.Collections.Generic;

namespace Atividade___1
{
    class Program
    {
        static void Main(string[] args)
        {

                string resposta = "";
                Pedido listadospedido = new Pedido();

            do{
                ItemPedido itempedidoprogram = new ItemPedido();

                Console.WriteLine("Qual foi a comida?");
                itempedidoprogram.descricao = Console.ReadLine();
                Console.WriteLine("Quantas unidades?");
                itempedidoprogram.quantidade = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual valor?");
                itempedidoprogram.valor = double.Parse(Console.ReadLine());
                listadospedido.AddPedido(itempedidoprogram);
              //  listadospedido.AddPedido(itempedidoprogram.valor);

                Console.WriteLine("Deseja fazer outro pedido? Digite sim ou não");
             resposta = Console.ReadLine();
            }while(resposta == "sim");
              
              Console.WriteLine(listadospedido.TotalizarPedido());
        }
    }
}
