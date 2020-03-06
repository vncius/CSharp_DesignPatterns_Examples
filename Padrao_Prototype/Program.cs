using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Padrao_Prototype.Model;

namespace Padrao_Prototype
{
    class Program

    {

        public static void Main()

        {

            // Criando a primeira instância como Produto1

            
            Produto _Produto1 = new Produto();
            _Produto1._IdCategoria = 01;
            _Produto1._Classificacao = "Jogos";
            _Produto1.IdCaracteristica = new IdCaracteristicas(001, 01, "Este jogo contém todos os recursos novos");


            // Listando informações do Objeto instânciado
            ListarInfor(_Produto1);

            // Criando a segunda instância e efetuar o Clone do objeto Produto1
            Produto _Produto2 = (Produto)_Produto1.Clone();


            // Listando informações do Objeto clonado
            ListarInfor(_Produto2);

           
            // Customizando valores nas propriedades do Produto1 e listando
            // os valores do Produto1 e Produto2
            _Produto1._IdCategoria = 02;
            _Produto1._Classificacao = "Poker";
            _Produto1.IdCaracteristica = new IdCaracteristicas(001, 01, "Contém todas as técnicas do poker");

            // Analisando o resultado depois da customização...
            Console.WriteLine("   Valores das propriedades do Produto1: ");
            ListarInfor(_Produto1);
            Console.WriteLine("   Valores das propriedades do Produto2:");
            ListarInfor(_Produto2);

            // Criando uma instância com o método copiar que efetuar o clone e
            // instância um nova classe caractetisticas para o Objeto
            Produto _ProdutoEspecial = (Produto)_Produto1.Copiar();

            // Alterando o valor do objeto Produto1 e analisando o comportamento...
            _Produto1._IdCategoria = 05;
            _Produto1._Classificacao = "Tecnologia";
            _Produto1.IdCaracteristica = new IdCaracteristicas(001, 01, "Novos recursos do .NET");

           
            // Analisando o resultado depois da alteração...
            Console.WriteLine("   Valores das propriedades do Produto1: ");
            ListarInfor(_Produto1);
            Console.WriteLine("   Valores das propriedades do ProdutoEspecial:");
            ListarInfor(_ProdutoEspecial);
        }


        public static void ListarInfor(Produto vProduto)
        {
            Console.WriteLine("");
            Console.WriteLine("Categoria: {0}", vProduto._IdCategoria);
            Console.WriteLine("Classificação: {0}", vProduto._Classificacao);
            Console.WriteLine("Caracteristicas: {0}, {1}, {2}", vProduto.IdCaracteristica._IdFabricante,
                                                                vProduto.IdCaracteristica._IdPreco, 
                                                                vProduto.IdCaracteristica._IdDescricao);
            Console.ReadLine();

        }
    }
}
