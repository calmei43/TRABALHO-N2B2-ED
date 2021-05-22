using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace EDA_N2B2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            #region registros
            RegistroCategoria rCategoria = new RegistroCategoria("categorias.txt");
            RegistroCliente rCliente = new RegistroCliente("clientes.txt");
            RegistroProduto rProduto = new RegistroProduto("produtos.txt");
            RegistroVenda rVenda = new RegistroVenda("vendas.txt", rCliente.GetContent(), rProduto.GetContent());
            #endregion

            sw.Start();
            OPCodes opCode = new OPCodes(rCategoria.GetContent(), rCliente.GetContent(),rProduto.GetContent(),
                                         rVenda.GetContent(), rVenda.GetVendasIndividuais(), rVenda.GetProdutosVendidos(),
                                         rVenda.GetTotalVendasPorCliente());

            sw.Stop();
            Console.Write("OPCODE CRIADO COM SUCESSO");
            Console.WriteLine("Segundos:" + sw.ElapsedMilliseconds / 1000);

            sw.Start();
           
            File.AppendAllText("resultado.txt",opCode.G().ToString());
            Console.Write("ARQUIVO ESCRITO COM SUCESSO");

            sw.Stop();
            Console.WriteLine("Segundos:" + sw.ElapsedMilliseconds / 1000);
        }
    }


}
