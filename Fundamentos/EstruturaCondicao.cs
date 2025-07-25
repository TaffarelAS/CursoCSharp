using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class EstruturaCondicao
    {
        public static void Executar()
        {
            /*
            string statusPedido = "Em transito";
            bool pagamentoConfirmado = true;
            
            if (statusPedido == "Pendente" && !pagamentoConfirmado)
            {
                Console.WriteLine("Aguardando Pagamento");
            }
            else if (statusPedido == "Pendente" && pagamentoConfirmado)
            {
                Console.WriteLine("Pedido Confirmado, Produto em separação");
            }
            else if (statusPedido == "Em Transito") 
            {
                Console.WriteLine("Pedido a caminho");
            }
            else if (statusPedido == "Entregue")
            {
                Console.WriteLine("Pedido entregue com sucesso");
            } else
            {
                Console.WriteLine("Status Desconhecido");
            }
            */
            Console.WriteLine("Digite o Usuario:");
            string usuario = Console.ReadLine();
            Console.WriteLine("Digite a senha");
            string senha = Console.ReadLine();

            if (usuario == "admin")
            {
                if (senha == "senha")
                {
                    Console.WriteLine("Login bem sucedido");
                }
                else
                {
                    Console.WriteLine("Senha Incorreta");
                }
            }
            else
            {
                Console.WriteLine("Usuario não encontrado");
            }
        }
    }
}
