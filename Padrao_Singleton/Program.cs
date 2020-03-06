using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Padrao_Singleton.Model;

namespace Padrao_Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// <summary> 
            /// CHAMADA SINGLETON SIMPLES
            /// </summary>
            //Cadeira _cadeira1 = Cadeira.Instance;
            //_cadeira1.Quantidade = 1;
 
            //Cadeira _cadeira2 = Cadeira.Instance;
            //_cadeira2.Quantidade = 5;
 
            //Console.WriteLine(_cadeira1.Quantidade.ToString());
            //Console.WriteLine(_cadeira2.Quantidade.ToString());
            //Console.ReadLine();


            /// <summary> 
            /// CHAMADA SINGLETON POR GENERICS
            /// </summary>
            CadeiraDeFio _cadeira = SingletonGenerics<CadeiraDeFio>.Instance();
            _cadeira.Quantidade = 5;
 
            CadeiraDeFio _cadeira2 = SingletonGenerics<CadeiraDeFio>.Instance();

            Mesa _mesa = SingletonGenerics<Mesa>.Instance();
            _mesa.Tamanho = "10metros";
 
            Console.WriteLine(_cadeira.Quantidade.ToString());
            Console.WriteLine(_mesa.Tamanho);
            Console.ReadLine();
        }
    }
}
