using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA_N2B2
{
    class OPCodes
    {
        Dictionary<object, object> rCategoria;
        Dictionary<object, object> rCliente;
        Dictionary<int, Produto> rProduto;
        Dictionary<string, int> totalVendasCliente;
        List<Venda> rVendas;
        HashSet<string> VendasIndividuais = new HashSet<string>();
        HashSet<string> ProdutosVendidos = new HashSet<string>();

        public OPCodes(Dictionary<object, object> dicCat, Dictionary<object, object> dicCliente,
                       Dictionary<int, Produto> dicProduto, List<Venda> listVenda,
                       HashSet<string> hashVendasInd, HashSet<string> hashProdutosVendidos,
                       Dictionary<string,int> dicTotalVendasCliente)
        {
            rCategoria = dicCat;
            rCliente = dicCliente;
            rProduto = dicProduto;
            rVendas = listVenda;
            VendasIndividuais = hashVendasInd;
            ProdutosVendidos = hashProdutosVendidos;
            totalVendasCliente = dicTotalVendasCliente;
        }

        #region OPCode A

        /// <summary>
        /// Calcula a qtde total de categorias
        /// </summary>
        /// <returns></returns>
        public int A() => rCategoria.Count();

        #endregion

        #region OPCode B

        /// <summary>
        /// Calcula a qtde total de produtos
        /// </summary>
        /// <returns></returns>
        public int B() => rProduto.Count();


        #endregion

        #region OPCode C
        /// <summary>
        /// Calcula a qtde total de clientes
        /// </summary>
        /// <returns></returns>
        public int C() => rCliente.Count();

        #endregion

        #region OPCode D
        public int D() => VendasIndividuais.Count();

        #endregion

        #region OPCode E
        public int E() => ProdutosVendidos.Count();

        #endregion

        #region OPCode F

        public int F()
        {
            var nomesNaoRepetidos = rCliente.Values.Distinct();
            return rCliente.Count() - nomesNaoRepetidos.Count();
        }
        #endregion

        #region OPCode G
        public StringBuilder G()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in totalVendasCliente)
            {
                sb.AppendLine($"{item.Key}|{rCliente[item.Key]}|{item.Value}");
            }

            return sb;
        }
        #endregion

        #region OPCode H

        #endregion

        #region OPCode I

        #endregion

        #region OPCode J

        #endregion

        #region OPCode K

        #endregion

        #region OPCode L

        #endregion

        #region OPCode M

        #endregion

        #region OPCode N

        #endregion

        #region OPCode O

        #endregion

        #region OPCode P

        //int P()
        //{
        //    int contador = 0;

        //    foreach (var cliente in rCliente.Keys)
        //    {
        //        foreach (var venda in rVendas)
        //        {
        //            if (!venda.Cliente == cliente)
        //                contador++;
        //        }
        //        if (!rVendas.Contains(cliente))
        //            contador++;
        //    }

        //    return contador;
        //}

        #endregion

        #region OPCode Q

        #endregion

    }
}
