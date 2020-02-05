using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Padrao_Singleton.Model;

namespace Padrao_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary> 
            /// CHAMADA SINGLETON SIMPLES
            /// </summary>
            Cadeira _cadeira1 = Cadeira.Instance;
            _cadeira1.Quantidade = 1;
 
            Cadeira _cadeira2 = Cadeira.Instance;
            _cadeira2.Quantidade = 5;
 
            Console.WriteLine(_cadeira1.Quantidade.ToString());
            Console.WriteLine(_cadeira2.Quantidade.ToString());
            Console.ReadLine();
        }
    }
}
